using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jakdu
{

    public partial class Form1 : Form
    {
        class image_cropper
        {
            public static bool isimageadded = false; // 추가 됐는지 확인 (isimageadded?)
            public static bool ispreviewloaded = false;

            public static int X_array; // X,Y 어레이 번호
            public static int Y_array;
            public static int X_array_max; // X,Y 어레이 최대 번호
            public static int Y_array_max;

            public static int arraysize; // 작두할 어레이 크기
            public static int X_size; // 작두할 이미지 크기 (X*Y)
            public static int Y_size;
            public static int X_locate; // 작두할 이미지 좌표 (X*Y)
            public static int Y_locate;

            public static string X_size_str; // 작두할 이미지 크기 (X*Y) 문자열 출력용
            public static string Y_size_str;
            public static string res_string;

            public static int crop_x_size;
            public static int crop_y_size;

            public static Bitmap original; // 원본 이미지
            public static string afilename = string.Empty; // afilename = 파일명

            public string res()
            {
                res_string = X_size_str + "x" + Y_size_str;
                return res_string;
            }

            public void xy_size()
            {
                X_size_str = original.Width.ToString();
                Y_size_str = original.Height.ToString();
                X_size = original.Width;
                Y_size = original.Height;
            }

            public static string GetFileNameWithoutExtension(string path)
            {
                return path;
            }

            public static Bitmap CropImage(Image source, int x, int y, int width, int height)
            {
                Rectangle crop = new Rectangle(x, y, width, height);

                var bmp = new Bitmap(crop.Width, crop.Height);
                using (var gr = Graphics.FromImage(bmp))
                {
                    gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
                }
                return bmp;
            }

            public void err_msg()
            {
                // 오류 창
                MessageBox.Show(afilename + "\rFailed Image Open!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void err_msg_crop()
            {
                // 오류 창
                MessageBox.Show("Crop Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void err_msg_complete()
            {
                // 완료 창
                MessageBox.Show("Crop Completed!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public void err_under_zero()
            {
                // 0 예외처리
                MessageBox.Show("size cannot be under 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void no_image_loaded()
            {
                // 0 예외처리
                MessageBox.Show("image not loaded!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void no_image_error()
            {
                // 0 예외처리
                MessageBox.Show("preview before save!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form1()
        {
            InitializeComponent();
            image_cropper.X_array_max = Int32.Parse(CalcArrayX.Text);
            image_cropper.Y_array_max = Int32.Parse(CalcArrayY.Text);

            
        }

        private void Openbutton_Click(object sender, EventArgs e)
        {
            // 이미지 열기 초기설정
            image_cropper opener = new image_cropper();
            PictureBox scr_able_box = new PictureBox();
            scr_able_box.Image = image_cropper.original = null;
            string original_image = string.Empty;
            try
            {
                // 예외처리 실행 부
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.InitialDirectory = @"C:\";
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image_cropper.afilename = dialog.FileName;
                    image_cropper.original = new Bitmap(dialog.FileName);

                    // 원본 이미지 해상도 읽는 부분
                    Originalview.Image = image_cropper.original;
                    opener.xy_size();
                    originalsize.Text = opener.res();

                    scr_able_box.Image = image_cropper.original;
                    scr_able_box.Height = image_cropper.original.Height;
                    scr_able_box.Width = image_cropper.original.Width;

                    scr_able_viewer.Controls.Clear();
                    scr_able_viewer.Controls.Add(scr_able_box);
                    scr_able_viewer.AutoScroll = true;

                }
            }
            catch(Exception)
            {
                opener.err_msg();
                return;
            }
            image_cropper.isimageadded = true; // 이미지 추가됨 플래그 지정
            Originalview.SizeMode = PictureBoxSizeMode.StretchImage; // 미리보기 창에 이미지 크기 조절
        }

        public void asarraysize_TextChanged(object sender, EventArgs e)
        {
            //작두할 어레이 크기 설정
            image_cropper assize = new image_cropper();
            try
            {
                int size = Int32.Parse(asarraysize.Text);
                image_cropper.arraysize = size;
                if (size < 1)
                {
                    assize.err_under_zero();
                    asarraysize.Text = "1";
                }
            }
            catch (Exception)
            {
                // 숫자 아님 예외처리
                asarraysize.Text = "1";
            }
        }

        private void arrayasx_TextChanged(object sender, EventArgs e)
        {
            image_cropper asx = new image_cropper();
            try
            {
                int arrayX = Int32.Parse(arrayasx.Text);
                image_cropper.X_array = arrayX;
                if (arrayX < 1)
                {
                    arrayX = 1;
                    arrayasx.Text = "1";
                }
                else if (arrayX > image_cropper.X_array_max)
                {
                    arrayasx.Text = image_cropper.X_array_max.ToString();
                    arrayX = image_cropper.X_array_max;
                }
            }
            catch (Exception)
            {
                // 숫자 아님 예외처리
                arrayasx.Text = "1";
            }
        }

        private void arrayasy_TextChanged(object sender, EventArgs e)
        {
            image_cropper asy = new image_cropper();
            try
            {
                int arrayY = Int32.Parse(arrayasy.Text);
                image_cropper.Y_array = arrayY;
                if (arrayY < 1)
                {
                    arrayY = 1;
                    arrayasy.Text = "1";
                }
                else if (arrayY > image_cropper.Y_array_max)
                {
                    arrayasy.Text = image_cropper.Y_array_max.ToString();
                    arrayY = image_cropper.Y_array_max;
                }
            }
            catch (Exception)
            {
                // 숫자 아님 예외처리
                arrayasy.Text = "1";
            }
        }

        private void ApplyBT_Click(object sender, EventArgs e)
        {
            image_cropper applyview = new image_cropper();
            if (image_cropper.isimageadded == false)
            {
                applyview.no_image_loaded();
                return;
            }
            int x = Int32.Parse(arrayasx.Text);
            int y = Int32.Parse(arrayasy.Text);
            int cropXsize = Int32.Parse(asarraysize.Text);
            int cropYsize = Int32.Parse(asheightsize.Text);
            image_cropper.X_locate = (x * image_cropper.crop_x_size) - image_cropper.crop_x_size;
            image_cropper.Y_locate = (y * image_cropper.crop_y_size) - image_cropper.crop_y_size;

            if (checkBox1.Checked == true)
            {
                int maxXarray = image_cropper.X_size / cropXsize;
                int maxYarray = image_cropper.Y_size / cropXsize;

                image_cropper.X_array_max = maxXarray;
                image_cropper.Y_array_max = maxYarray;

                image_cropper.arraysize = cropXsize;
                image_cropper.crop_x_size = image_cropper.crop_y_size = image_cropper.arraysize;

            }
            else if (checkBox1.Checked == false)
            {
                int maxXarray = image_cropper.X_size / cropXsize;
                int maxYarray = image_cropper.Y_size / cropYsize;

                image_cropper.X_array_max = maxXarray;
                image_cropper.Y_array_max = maxYarray;

                image_cropper.crop_x_size = cropXsize;
                image_cropper.crop_y_size = cropYsize;
            }
            CalcArrayX.Text = image_cropper.X_array_max.ToString();
            CalcArrayY.Text = image_cropper.Y_array_max.ToString();

            Croppedview.Image = image_cropper.CropImage(image_cropper.original, image_cropper.X_locate, image_cropper.Y_locate, image_cropper.crop_x_size, image_cropper.crop_y_size);
            crop_temp.Image = Croppedview.Image;
            Croppedview.SizeMode = PictureBoxSizeMode.StretchImage;
            image_cropper.ispreviewloaded = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label3.Text = "Crop Array Size";
                asheightsize.Visible = false;
                label12.Visible = false;
            }
            else if(checkBox1.Checked == false)
            {
                label3.Text = "Width";
                asheightsize.Visible = true;
                label12.Visible = true;
            }
        }

        private void Saveoneimage_Click(object sender, EventArgs e)
        {
            image_cropper once = new image_cropper();
            if (image_cropper.ispreviewloaded == false)
            {
                once.no_image_error();
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Format| *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                crop_temp.Image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }           
        }

        private void Saveallimage_Click(object sender, EventArgs e)
        {
            image_cropper all = new image_cropper();
            if (image_cropper.ispreviewloaded == false)
                {
                all.no_image_error();
                return;
                }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files| *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                arrayasx.Text = "1";
                arrayasy.Text = "1";
                int arrayX = Int32.Parse(arrayasx.Text);
                int arrayY = Int32.Parse(arrayasy.Text);
                int FC = 1;
                try
                    {
                    while (arrayY < image_cropper.Y_array_max)
                    {
                        while (arrayX < image_cropper.X_array_max)
                            {
                        Croppedview.Image = image_cropper.CropImage(image_cropper.original, image_cropper.X_locate, image_cropper.Y_locate, image_cropper.crop_x_size, image_cropper.crop_y_size);
                        crop_temp.Image = Croppedview.Image;
                        crop_temp.Image.Save(filename + "(" + FC + ").png", System.Drawing.Imaging.ImageFormat.Png);
                        arrayX = arrayX + 1;
                        FC = FC + 1;
                        image_cropper.X_locate = (arrayX * image_cropper.crop_x_size) - image_cropper.crop_x_size;
                        image_cropper.Y_locate = (arrayY * image_cropper.crop_y_size) - image_cropper.crop_y_size;
                        }
                    arrayY = arrayY + 1;
                    arrayX = 1;
                    }
                    }
                catch
                {
                    all.err_msg_crop();
                }
                all.err_msg_complete();
            }
        }

        private void Upbutton_Click(object sender, EventArgs e)
        {
            if(image_cropper.isimageadded == true)
            {
                try
                {
                int arrayY = Int32.Parse(arrayasy.Text);
                arrayY = arrayY - 1;
                image_cropper.Y_array = arrayY;
                arrayasy.Text = arrayY.ToString();
                ApplyBT_Click(sender, e);
                    if (arrayY < 1)
                    {
                        arrayasy.Text = "1";
                    }
                    else if (arrayY > image_cropper.Y_array_max)
                    {
                        arrayasy.Text = image_cropper.Y_array_max.ToString();
                    }
                }
                catch (Exception)
                {
                    arrayasy.Text = "1";
                }
            }
        }

        private void Leftbutton_Click(object sender, EventArgs e)
        {
            if (image_cropper.isimageadded == true)
            {
                try
                {
                    int arrayX = Int32.Parse(arrayasx.Text);
                    arrayX = arrayX - 1;
                    image_cropper.X_array = arrayX;
                    arrayasx.Text = arrayX.ToString();
                    ApplyBT_Click(sender, e);
                    if (arrayX < 1)
                    {
                        arrayasx.Text = "1";
                    }
                    else if (arrayX > image_cropper.X_array_max)
                    {
                        arrayasx.Text = image_cropper.X_array_max.ToString();
                    }
                }
                catch (Exception)
                {
                    arrayasx.Text = "1";
                }
            }
        }

        private void Rightbutton_Click(object sender, EventArgs e)
        {
            if (image_cropper.isimageadded == true)
            {
                try
                {
                    int arrayX = Int32.Parse(arrayasx.Text);
                    arrayX = arrayX + 1;
                    image_cropper.X_array = arrayX;
                    arrayasx.Text = arrayX.ToString();
                    ApplyBT_Click(sender, e);
                    if (arrayX < 1)
                    {
                        arrayasx.Text = "1";
                    }
                    else if (arrayX > image_cropper.X_array_max)
                    {
                        arrayasx.Text = image_cropper.X_array_max.ToString();
                    }
                }
                catch (Exception)
                {
                    arrayasx.Text = "1";
                }
            }
        }

        private void Downbutton_Click(object sender, EventArgs e)
        {
            if (image_cropper.isimageadded == true)
            {
                try
                {
                    int arrayY = Int32.Parse(arrayasy.Text);
                    arrayY = arrayY + 1;
                    image_cropper.Y_array = arrayY;
                    arrayasy.Text = arrayY.ToString();
                    ApplyBT_Click(sender, e);
                    if (arrayY < 1)
                    {
                        arrayasy.Text = "1";
                    }
                    else if (arrayY > image_cropper.Y_array_max)
                    {
                        arrayasy.Text = image_cropper.Y_array_max.ToString();
                    }
                }
                catch (Exception)
                {
                    arrayasy.Text = "1";
                }
            }
        }

        private void scroll_check_CheckedChanged(object sender, EventArgs e)
        {
            if(scroll_check.Checked == true)
            {
                Originalview.Visible = true;
                scr_able_viewer.Visible = false;
            }
            if (scroll_check.Checked == false)
            {
                Originalview.Visible = false;
                scr_able_viewer.Visible = true;
            }
        }
    }
}

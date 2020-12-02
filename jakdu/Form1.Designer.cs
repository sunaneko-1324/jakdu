
namespace jakdu
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Originalview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Croppedview = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.asarraysize = new System.Windows.Forms.TextBox();
            this.Openbutton = new System.Windows.Forms.Button();
            this.Leftbutton = new System.Windows.Forms.Button();
            this.Rightbutton = new System.Windows.Forms.Button();
            this.Upbutton = new System.Windows.Forms.Button();
            this.Downbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.originalsize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arrayasx = new System.Windows.Forms.TextBox();
            this.arrayasy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Saveoneimage = new System.Windows.Forms.Button();
            this.Saveallimage = new System.Windows.Forms.Button();
            this.ApplyBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CalcArrayY = new System.Windows.Forms.TextBox();
            this.CalcArrayX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.asheightsize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.crop_temp = new System.Windows.Forms.PictureBox();
            this.scr_able_viewer = new System.Windows.Forms.Panel();
            this.scroll_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Originalview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Croppedview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // Originalview
            // 
            this.Originalview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Originalview.Location = new System.Drawing.Point(11, 18);
            this.Originalview.Margin = new System.Windows.Forms.Padding(2);
            this.Originalview.Name = "Originalview";
            this.Originalview.Size = new System.Drawing.Size(210, 210);
            this.Originalview.TabIndex = 0;
            this.Originalview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crop Preview";
            // 
            // Croppedview
            // 
            this.Croppedview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Croppedview.Location = new System.Drawing.Point(11, 251);
            this.Croppedview.Margin = new System.Windows.Forms.Padding(2);
            this.Croppedview.Name = "Croppedview";
            this.Croppedview.Size = new System.Drawing.Size(210, 210);
            this.Croppedview.TabIndex = 3;
            this.Croppedview.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crop Array Size";
            // 
            // asarraysize
            // 
            this.asarraysize.Location = new System.Drawing.Point(242, 265);
            this.asarraysize.Margin = new System.Windows.Forms.Padding(2);
            this.asarraysize.Name = "asarraysize";
            this.asarraysize.Size = new System.Drawing.Size(91, 21);
            this.asarraysize.TabIndex = 1;
            this.asarraysize.Text = "64";
            this.asarraysize.TextChanged += new System.EventHandler(this.asarraysize_TextChanged);
            // 
            // Openbutton
            // 
            this.Openbutton.Location = new System.Drawing.Point(242, 188);
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.Size = new System.Drawing.Size(119, 31);
            this.Openbutton.TabIndex = 1;
            this.Openbutton.Text = "Open Image(&O)";
            this.Openbutton.UseVisualStyleBackColor = true;
            this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
            // 
            // Leftbutton
            // 
            this.Leftbutton.Location = new System.Drawing.Point(242, 405);
            this.Leftbutton.Name = "Leftbutton";
            this.Leftbutton.Size = new System.Drawing.Size(31, 31);
            this.Leftbutton.TabIndex = 3;
            this.Leftbutton.Text = "←";
            this.Leftbutton.UseVisualStyleBackColor = true;
            this.Leftbutton.Click += new System.EventHandler(this.Leftbutton_Click);
            // 
            // Rightbutton
            // 
            this.Rightbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Rightbutton.Location = new System.Drawing.Point(304, 405);
            this.Rightbutton.Name = "Rightbutton";
            this.Rightbutton.Size = new System.Drawing.Size(31, 31);
            this.Rightbutton.TabIndex = 6;
            this.Rightbutton.Text = "→";
            this.Rightbutton.UseVisualStyleBackColor = true;
            this.Rightbutton.Click += new System.EventHandler(this.Rightbutton_Click);
            // 
            // Upbutton
            // 
            this.Upbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Upbutton.Location = new System.Drawing.Point(273, 368);
            this.Upbutton.Name = "Upbutton";
            this.Upbutton.Size = new System.Drawing.Size(31, 31);
            this.Upbutton.TabIndex = 4;
            this.Upbutton.Text = "↑";
            this.Upbutton.UseVisualStyleBackColor = true;
            this.Upbutton.Click += new System.EventHandler(this.Upbutton_Click);
            // 
            // Downbutton
            // 
            this.Downbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Downbutton.Location = new System.Drawing.Point(273, 442);
            this.Downbutton.Name = "Downbutton";
            this.Downbutton.Size = new System.Drawing.Size(31, 31);
            this.Downbutton.TabIndex = 5;
            this.Downbutton.Text = "↓";
            this.Downbutton.UseVisualStyleBackColor = true;
            this.Downbutton.Click += new System.EventHandler(this.Downbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preview Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Image Size";
            // 
            // originalsize
            // 
            this.originalsize.Enabled = false;
            this.originalsize.Location = new System.Drawing.Point(242, 33);
            this.originalsize.Name = "originalsize";
            this.originalsize.Size = new System.Drawing.Size(93, 21);
            this.originalsize.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Array View";
            // 
            // arrayasx
            // 
            this.arrayasx.Location = new System.Drawing.Point(374, 448);
            this.arrayasx.Name = "arrayasx";
            this.arrayasx.Size = new System.Drawing.Size(50, 21);
            this.arrayasx.TabIndex = 7;
            this.arrayasx.Text = "1";
            this.arrayasx.TextChanged += new System.EventHandler(this.arrayasx_TextChanged);
            // 
            // arrayasy
            // 
            this.arrayasy.Location = new System.Drawing.Point(447, 448);
            this.arrayasy.Name = "arrayasy";
            this.arrayasy.Size = new System.Drawing.Size(50, 21);
            this.arrayasy.TabIndex = 8;
            this.arrayasy.Text = "1";
            this.arrayasy.TextChanged += new System.EventHandler(this.arrayasy_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = ",";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "(x), (y)";
            // 
            // Saveoneimage
            // 
            this.Saveoneimage.Location = new System.Drawing.Point(242, 514);
            this.Saveoneimage.Name = "Saveoneimage";
            this.Saveoneimage.Size = new System.Drawing.Size(119, 31);
            this.Saveoneimage.TabIndex = 9;
            this.Saveoneimage.Text = "Save Preview(&S)";
            this.Saveoneimage.UseVisualStyleBackColor = true;
            this.Saveoneimage.Click += new System.EventHandler(this.Saveoneimage_Click);
            // 
            // Saveallimage
            // 
            this.Saveallimage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Saveallimage.Location = new System.Drawing.Point(378, 514);
            this.Saveallimage.Name = "Saveallimage";
            this.Saveallimage.Size = new System.Drawing.Size(119, 31);
            this.Saveallimage.TabIndex = 10;
            this.Saveallimage.Text = "Save All(&D)";
            this.Saveallimage.UseVisualStyleBackColor = true;
            this.Saveallimage.Click += new System.EventHandler(this.Saveallimage_Click);
            // 
            // ApplyBT
            // 
            this.ApplyBT.Location = new System.Drawing.Point(242, 291);
            this.ApplyBT.Name = "ApplyBT";
            this.ApplyBT.Size = new System.Drawing.Size(119, 28);
            this.ApplyBT.TabIndex = 2;
            this.ApplyBT.Text = "Preview(&P)";
            this.ApplyBT.UseVisualStyleBackColor = true;
            this.ApplyBT.Click += new System.EventHandler(this.ApplyBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(372, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "(x), (y)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(432, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = ",";
            // 
            // CalcArrayY
            // 
            this.CalcArrayY.Enabled = false;
            this.CalcArrayY.Location = new System.Drawing.Point(447, 378);
            this.CalcArrayY.Name = "CalcArrayY";
            this.CalcArrayY.Size = new System.Drawing.Size(50, 21);
            this.CalcArrayY.TabIndex = 19;
            this.CalcArrayY.Text = "1";
            // 
            // CalcArrayX
            // 
            this.CalcArrayX.Enabled = false;
            this.CalcArrayX.Location = new System.Drawing.Point(374, 378);
            this.CalcArrayX.Name = "CalcArrayX";
            this.CalcArrayX.Size = new System.Drawing.Size(50, 21);
            this.CalcArrayX.TabIndex = 20;
            this.CalcArrayX.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(372, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "Calculated Array";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(374, 298);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Array is 1:1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // asheightsize
            // 
            this.asheightsize.Location = new System.Drawing.Point(369, 265);
            this.asheightsize.Margin = new System.Windows.Forms.Padding(2);
            this.asheightsize.Name = "asheightsize";
            this.asheightsize.Size = new System.Drawing.Size(91, 21);
            this.asheightsize.TabIndex = 24;
            this.asheightsize.Text = "64";
            this.asheightsize.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(367, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "Height";
            this.label12.Visible = false;
            // 
            // crop_temp
            // 
            this.crop_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crop_temp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crop_temp.Location = new System.Drawing.Point(68, 306);
            this.crop_temp.Margin = new System.Windows.Forms.Padding(2);
            this.crop_temp.Name = "crop_temp";
            this.crop_temp.Size = new System.Drawing.Size(60, 60);
            this.crop_temp.TabIndex = 26;
            this.crop_temp.TabStop = false;
            this.crop_temp.Visible = false;
            // 
            // scr_able_viewer
            // 
            this.scr_able_viewer.Location = new System.Drawing.Point(11, 18);
            this.scr_able_viewer.Name = "scr_able_viewer";
            this.scr_able_viewer.Size = new System.Drawing.Size(210, 210);
            this.scr_able_viewer.TabIndex = 27;
            // 
            // scroll_check
            // 
            this.scroll_check.AutoSize = true;
            this.scroll_check.Checked = true;
            this.scroll_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_check.Location = new System.Drawing.Point(242, 166);
            this.scroll_check.Name = "scroll_check";
            this.scroll_check.Size = new System.Drawing.Size(95, 16);
            this.scroll_check.TabIndex = 28;
            this.scroll_check.Text = "Stretch View";
            this.scroll_check.UseVisualStyleBackColor = true;
            this.scroll_check.CheckedChanged += new System.EventHandler(this.scroll_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(509, 557);
            this.Controls.Add(this.Originalview);
            this.Controls.Add(this.scroll_check);
            this.Controls.Add(this.scr_able_viewer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.asheightsize);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CalcArrayY);
            this.Controls.Add(this.CalcArrayX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ApplyBT);
            this.Controls.Add(this.Saveallimage);
            this.Controls.Add(this.Saveoneimage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrayasy);
            this.Controls.Add(this.arrayasx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originalsize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Downbutton);
            this.Controls.Add(this.Upbutton);
            this.Controls.Add(this.Rightbutton);
            this.Controls.Add(this.Leftbutton);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.asarraysize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Croppedview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crop_temp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jakdu";
            ((System.ComponentModel.ISupportInitialize)(this.Originalview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Croppedview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Originalview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Croppedview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox asarraysize;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.Button Leftbutton;
        private System.Windows.Forms.Button Rightbutton;
        private System.Windows.Forms.Button Upbutton;
        private System.Windows.Forms.Button Downbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox originalsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox arrayasx;
        private System.Windows.Forms.TextBox arrayasy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Saveoneimage;
        private System.Windows.Forms.Button Saveallimage;
        private System.Windows.Forms.Button ApplyBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CalcArrayY;
        private System.Windows.Forms.TextBox CalcArrayX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox asheightsize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox crop_temp;
        private System.Windows.Forms.Panel scr_able_viewer;
        private System.Windows.Forms.CheckBox scroll_check;
    }
}


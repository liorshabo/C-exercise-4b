namespace project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Qustion = new System.Windows.Forms.Label();
            this.Ans1 = new System.Windows.Forms.Button();
            this.Ans2 = new System.Windows.Forms.Button();
            this.Ans3 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.HowmuchT = new System.Windows.Forms.Label();
            this.checkmasov = new System.Windows.Forms.CheckBox();
            this.checkgrade = new System.Windows.Forms.CheckBox();
            this.txt_mashov = new System.Windows.Forms.TextBox();
            this.btn_mashov = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Qustion
            // 
            this.Qustion.AutoSize = true;
            this.Qustion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Qustion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qustion.Location = new System.Drawing.Point(386, 87);
            this.Qustion.Name = "Qustion";
            this.Qustion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Qustion.Size = new System.Drawing.Size(0, 23);
            this.Qustion.TabIndex = 0;
            // 
            // Ans1
            // 
            this.Ans1.BackColor = System.Drawing.Color.RosyBrown;
            this.Ans1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans1.Location = new System.Drawing.Point(78, 352);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(158, 34);
            this.Ans1.TabIndex = 1;
            this.Ans1.UseVisualStyleBackColor = false;
            this.Ans1.Click += new System.EventHandler(this.Ans1_Click);
            // 
            // Ans2
            // 
            this.Ans2.BackColor = System.Drawing.Color.RosyBrown;
            this.Ans2.Location = new System.Drawing.Point(489, 351);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(145, 35);
            this.Ans2.TabIndex = 2;
            this.Ans2.UseVisualStyleBackColor = false;
            this.Ans2.Click += new System.EventHandler(this.Ans2_Click);
            // 
            // Ans3
            // 
            this.Ans3.BackColor = System.Drawing.Color.RosyBrown;
            this.Ans3.Location = new System.Drawing.Point(844, 348);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(136, 38);
            this.Ans3.TabIndex = 3;
            this.Ans3.UseVisualStyleBackColor = false;
            this.Ans3.Click += new System.EventHandler(this.Ans3_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.IndianRed;
            this.TextBox.Location = new System.Drawing.Point(400, 420);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(326, 22);
            this.TextBox.TabIndex = 4;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(22, 126);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(305, 216);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(400, 126);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(312, 216);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(763, 126);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(289, 216);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 7;
            this.PictureBox3.TabStop = false;
            // 
            // HowmuchT
            // 
            this.HowmuchT.AutoSize = true;
            this.HowmuchT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HowmuchT.Location = new System.Drawing.Point(51, 28);
            this.HowmuchT.Name = "HowmuchT";
            this.HowmuchT.Size = new System.Drawing.Size(0, 17);
            this.HowmuchT.TabIndex = 8;
            // 
            // checkmasov
            // 
            this.checkmasov.AutoSize = true;
            this.checkmasov.BackColor = System.Drawing.Color.Transparent;
            this.checkmasov.Location = new System.Drawing.Point(139, 383);
            this.checkmasov.Name = "checkmasov";
            this.checkmasov.Size = new System.Drawing.Size(54, 21);
            this.checkmasov.TabIndex = 9;
            this.checkmasov.Text = "משוב";
            this.checkmasov.UseVisualStyleBackColor = false;
            this.checkmasov.CheckedChanged += new System.EventHandler(this.checkmasov_CheckedChanged);
            // 
            // checkgrade
            // 
            this.checkgrade.AutoSize = true;
            this.checkgrade.Location = new System.Drawing.Point(894, 383);
            this.checkgrade.Name = "checkgrade";
            this.checkgrade.Size = new System.Drawing.Size(43, 21);
            this.checkgrade.TabIndex = 10;
            this.checkgrade.Text = "ציון";
            this.checkgrade.UseVisualStyleBackColor = true;
            this.checkgrade.CheckedChanged += new System.EventHandler(this.checkgrade_CheckedChanged);
            // 
            // txt_mashov
            // 
            this.txt_mashov.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_mashov.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_mashov.Location = new System.Drawing.Point(498, 12);
            this.txt_mashov.Multiline = true;
            this.txt_mashov.Name = "txt_mashov";
            this.txt_mashov.Size = new System.Drawing.Size(554, 121);
            this.txt_mashov.TabIndex = 11;
            this.txt_mashov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_mashov
            // 
            this.btn_mashov.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mashov.Location = new System.Drawing.Point(390, 53);
            this.btn_mashov.Name = "btn_mashov";
            this.btn_mashov.Size = new System.Drawing.Size(87, 29);
            this.btn_mashov.TabIndex = 12;
            this.btn_mashov.Text = "סיום";
            this.btn_mashov.UseVisualStyleBackColor = true;
            this.btn_mashov.Click += new System.EventHandler(this.btn_mashov_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.richTextBox.Location = new System.Drawing.Point(333, 90);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox.Size = new System.Drawing.Size(145, 74);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.RosyBrown;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.exit.Location = new System.Drawing.Point(469, 187);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(188, 90);
            this.exit.TabIndex = 14;
            this.exit.Text = "יציאה";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.LightCoral;
            this.btn_color.Location = new System.Drawing.Point(637, 215);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 23);
            this.btn_color.TabIndex = 15;
            this.btn_color.Text = "!לחץ עליי";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btn_mashov);
            this.Controls.Add(this.txt_mashov);
            this.Controls.Add(this.checkgrade);
            this.Controls.Add(this.checkmasov);
            this.Controls.Add(this.HowmuchT);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.Qustion);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qustion;
        private System.Windows.Forms.Button Ans1;
        private System.Windows.Forms.Button Ans2;
        private System.Windows.Forms.Button Ans3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.Label HowmuchT;
        private System.Windows.Forms.CheckBox checkmasov;
        private System.Windows.Forms.CheckBox checkgrade;
        private System.Windows.Forms.TextBox txt_mashov;
        private System.Windows.Forms.Button btn_mashov;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_color;
    }
}


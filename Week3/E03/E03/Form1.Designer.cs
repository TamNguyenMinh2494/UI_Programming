namespace E03
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
            this.label1 = new System.Windows.Forms.Label();
            this.nUDFont = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRegular = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBoldItalic = new System.Windows.Forms.CheckBox();
            this.rdAutoColor = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdLeft = new System.Windows.Forms.RadioButton();
            this.rdRight = new System.Windows.Forms.RadioButton();
            this.rdCenter = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbHeader = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFont)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Size:";
            // 
            // nUDFont
            // 
            this.nUDFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDFont.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDFont.Location = new System.Drawing.Point(137, 81);
            this.nUDFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nUDFont.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDFont.Name = "nUDFont";
            this.nUDFont.Size = new System.Drawing.Size(90, 27);
            this.nUDFont.TabIndex = 2;
            this.nUDFont.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDFont.ValueChanged += new System.EventHandler(this.nUDFont_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBoldItalic);
            this.groupBox1.Controls.Add(this.cbItalic);
            this.groupBox1.Controls.Add(this.cbBold);
            this.groupBox1.Controls.Add(this.cbRegular);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBlue);
            this.groupBox2.Controls.Add(this.rdGreen);
            this.groupBox2.Controls.Add(this.rdRed);
            this.groupBox2.Controls.Add(this.rdAutoColor);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdCenter);
            this.groupBox3.Controls.Add(this.rdRight);
            this.groupBox3.Controls.Add(this.rdLeft);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(509, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 245);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TextAlign";
            // 
            // cbRegular
            // 
            this.cbRegular.AutoSize = true;
            this.cbRegular.Location = new System.Drawing.Point(47, 37);
            this.cbRegular.Name = "cbRegular";
            this.cbRegular.Size = new System.Drawing.Size(88, 23);
            this.cbRegular.TabIndex = 0;
            this.cbRegular.Text = "Regular";
            this.cbRegular.UseVisualStyleBackColor = true;
            this.cbRegular.CheckedChanged += new System.EventHandler(this.cbRegular_CheckedChanged);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(47, 84);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(64, 23);
            this.cbBold.TabIndex = 1;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(47, 135);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(68, 23);
            this.cbItalic.TabIndex = 2;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbBoldItalic
            // 
            this.cbBoldItalic.AutoSize = true;
            this.cbBoldItalic.Location = new System.Drawing.Point(47, 192);
            this.cbBoldItalic.Name = "cbBoldItalic";
            this.cbBoldItalic.Size = new System.Drawing.Size(138, 23);
            this.cbBoldItalic.TabIndex = 3;
            this.cbBoldItalic.Text = "Bold and Italic";
            this.cbBoldItalic.UseVisualStyleBackColor = true;
            this.cbBoldItalic.CheckedChanged += new System.EventHandler(this.cbBoldItalic_CheckedChanged);
            // 
            // rdAutoColor
            // 
            this.rdAutoColor.AutoSize = true;
            this.rdAutoColor.Location = new System.Drawing.Point(44, 37);
            this.rdAutoColor.Name = "rdAutoColor";
            this.rdAutoColor.Size = new System.Drawing.Size(106, 23);
            this.rdAutoColor.TabIndex = 0;
            this.rdAutoColor.TabStop = true;
            this.rdAutoColor.Text = "AutoColor";
            this.rdAutoColor.UseVisualStyleBackColor = true;
            this.rdAutoColor.CheckedChanged += new System.EventHandler(this.rdAutoColor_CheckedChanged);
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Location = new System.Drawing.Point(44, 84);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(56, 23);
            this.rdRed.TabIndex = 1;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            this.rdRed.CheckedChanged += new System.EventHandler(this.rdRed_CheckedChanged);
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Location = new System.Drawing.Point(44, 135);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(74, 23);
            this.rdGreen.TabIndex = 2;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(44, 192);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(62, 23);
            this.rdBlue.TabIndex = 3;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // rdLeft
            // 
            this.rdLeft.AutoSize = true;
            this.rdLeft.Location = new System.Drawing.Point(43, 58);
            this.rdLeft.Name = "rdLeft";
            this.rdLeft.Size = new System.Drawing.Size(57, 23);
            this.rdLeft.TabIndex = 0;
            this.rdLeft.TabStop = true;
            this.rdLeft.Text = "Left";
            this.rdLeft.UseVisualStyleBackColor = true;
            this.rdLeft.CheckedChanged += new System.EventHandler(this.rdLeft_CheckedChanged);
            // 
            // rdRight
            // 
            this.rdRight.AutoSize = true;
            this.rdRight.Location = new System.Drawing.Point(43, 121);
            this.rdRight.Name = "rdRight";
            this.rdRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdRight.Size = new System.Drawing.Size(69, 23);
            this.rdRight.TabIndex = 1;
            this.rdRight.TabStop = true;
            this.rdRight.Text = "Right";
            this.rdRight.UseVisualStyleBackColor = true;
            this.rdRight.CheckedChanged += new System.EventHandler(this.rdRight_CheckedChanged);
            // 
            // rdCenter
            // 
            this.rdCenter.AutoSize = true;
            this.rdCenter.Location = new System.Drawing.Point(43, 182);
            this.rdCenter.Name = "rdCenter";
            this.rdCenter.Size = new System.Drawing.Size(78, 23);
            this.rdCenter.TabIndex = 2;
            this.rdCenter.TabStop = true;
            this.rdCenter.Text = "Center";
            this.rdCenter.UseVisualStyleBackColor = true;
            this.rdCenter.CheckedChanged += new System.EventHandler(this.rdCenter_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(670, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tbHeader
            // 
            this.tbHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeader.Location = new System.Drawing.Point(18, 12);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(770, 48);
            this.tbHeader.TabIndex = 7;
            this.tbHeader.Text = "Trung Tâm Đào Tạo CNTT";
            this.tbHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nUDFont);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDFont)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBoldItalic;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.CheckBox cbRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.RadioButton rdAutoColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdCenter;
        private System.Windows.Forms.RadioButton rdRight;
        private System.Windows.Forms.RadioButton rdLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbHeader;
    }
}


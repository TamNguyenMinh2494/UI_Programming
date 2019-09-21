namespace E02
{
    partial class Form2
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
            this.lbHead = new System.Windows.Forms.Label();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.rdbBoldItalic = new System.Windows.Forms.RadioButton();
            this.rdbItalic = new System.Windows.Forms.RadioButton();
            this.rdbBold = new System.Windows.Forms.RadioButton();
            this.rdbRegular = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbFont.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.Location = new System.Drawing.Point(95, 31);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(578, 30);
            this.lbHead.TabIndex = 0;
            this.lbHead.Text = "TRUNG TÂM ĐÀO TẠO CNTT TP HỒ CHÍ MINH";
            // 
            // grbFont
            // 
            this.grbFont.Controls.Add(this.rdbBoldItalic);
            this.grbFont.Controls.Add(this.rdbItalic);
            this.grbFont.Controls.Add(this.rdbBold);
            this.grbFont.Controls.Add(this.rdbRegular);
            this.grbFont.Location = new System.Drawing.Point(44, 116);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(255, 258);
            this.grbFont.TabIndex = 1;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "FONT STYLE";
            // 
            // rdbBoldItalic
            // 
            this.rdbBoldItalic.AutoSize = true;
            this.rdbBoldItalic.Location = new System.Drawing.Point(74, 217);
            this.rdbBoldItalic.Name = "rdbBoldItalic";
            this.rdbBoldItalic.Size = new System.Drawing.Size(92, 17);
            this.rdbBoldItalic.TabIndex = 3;
            this.rdbBoldItalic.TabStop = true;
            this.rdbBoldItalic.Text = "Bold and Italic";
            this.rdbBoldItalic.UseVisualStyleBackColor = true;
            this.rdbBoldItalic.CheckedChanged += new System.EventHandler(this.rdbBoldItalic_CheckedChanged);
            // 
            // rdbItalic
            // 
            this.rdbItalic.AutoSize = true;
            this.rdbItalic.Location = new System.Drawing.Point(74, 147);
            this.rdbItalic.Name = "rdbItalic";
            this.rdbItalic.Size = new System.Drawing.Size(47, 17);
            this.rdbItalic.TabIndex = 2;
            this.rdbItalic.TabStop = true;
            this.rdbItalic.Text = "Italic";
            this.rdbItalic.UseVisualStyleBackColor = true;
            this.rdbItalic.CheckedChanged += new System.EventHandler(this.rdbItalic_CheckedChanged);
            // 
            // rdbBold
            // 
            this.rdbBold.AutoSize = true;
            this.rdbBold.Location = new System.Drawing.Point(74, 88);
            this.rdbBold.Name = "rdbBold";
            this.rdbBold.Size = new System.Drawing.Size(46, 17);
            this.rdbBold.TabIndex = 1;
            this.rdbBold.TabStop = true;
            this.rdbBold.Text = "Bold";
            this.rdbBold.UseVisualStyleBackColor = true;
            this.rdbBold.CheckedChanged += new System.EventHandler(this.rdbBold_CheckedChanged);
            // 
            // rdbRegular
            // 
            this.rdbRegular.AutoSize = true;
            this.rdbRegular.Location = new System.Drawing.Point(74, 19);
            this.rdbRegular.Name = "rdbRegular";
            this.rdbRegular.Size = new System.Drawing.Size(62, 17);
            this.rdbRegular.TabIndex = 0;
            this.rdbRegular.TabStop = true;
            this.rdbRegular.Text = "Regular";
            this.rdbRegular.UseVisualStyleBackColor = true;
            this.rdbRegular.CheckedChanged += new System.EventHandler(this.rdbRegular_CheckedChanged);
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.rdbBlue);
            this.grbColor.Controls.Add(this.rdbGreen);
            this.grbColor.Controls.Add(this.rdbRed);
            this.grbColor.Controls.Add(this.rdbAuto);
            this.grbColor.Location = new System.Drawing.Point(430, 116);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(271, 257);
            this.grbColor.TabIndex = 2;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "COLOR";
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(107, 217);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 3;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            this.rdbBlue.CheckedChanged += new System.EventHandler(this.rdbBlue_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(107, 147);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 2;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.rdbGreen_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(107, 88);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 1;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            this.rdbRed.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Location = new System.Drawing.Point(107, 19);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(74, 17);
            this.rdbAuto.TabIndex = 0;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "Auto Color";
            this.rdbAuto.UseVisualStyleBackColor = true;
            this.rdbAuto.CheckedChanged += new System.EventHandler(this.rdbAuto_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(626, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.lbHead);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.RadioButton rdbBoldItalic;
        private System.Windows.Forms.RadioButton rdbItalic;
        private System.Windows.Forms.RadioButton rdbBold;
        private System.Windows.Forms.RadioButton rdbRegular;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.Button btnExit;
    }
}
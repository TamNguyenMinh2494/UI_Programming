namespace E02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.grbOps = new System.Windows.Forms.GroupBox();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.lbRes = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.lbNum2);
            this.groupBox1.Controls.Add(this.lbNum1);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(72, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(259, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(72, 24);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(259, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(9, 67);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(38, 13);
            this.lbNum2.TabIndex = 1;
            this.lbNum2.Text = "Num 2";
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(9, 26);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(38, 13);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Num 1";
            // 
            // grbOps
            // 
            this.grbOps.Controls.Add(this.rdbDiv);
            this.grbOps.Controls.Add(this.rdbMul);
            this.grbOps.Controls.Add(this.rdbSub);
            this.grbOps.Controls.Add(this.rdbAdd);
            this.grbOps.Location = new System.Drawing.Point(11, 155);
            this.grbOps.Name = "grbOps";
            this.grbOps.Size = new System.Drawing.Size(776, 72);
            this.grbOps.TabIndex = 1;
            this.grbOps.TabStop = false;
            this.grbOps.Text = "Operators";
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(618, 33);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(41, 17);
            this.rdbDiv.TabIndex = 3;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Div";
            this.rdbDiv.UseVisualStyleBackColor = true;
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.Location = new System.Drawing.Point(414, 33);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(42, 17);
            this.rdbMul.TabIndex = 2;
            this.rdbMul.TabStop = true;
            this.rdbMul.Text = "Mul";
            this.rdbMul.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(210, 33);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(44, 17);
            this.rdbSub.TabIndex = 1;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Sub";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(24, 33);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(44, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(19, 270);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(50, 13);
            this.lbRes.TabIndex = 2;
            this.lbRes.Text = "RESULT";
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Location = new System.Drawing.Point(80, 323);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(50, 13);
            this.lbKq.TabIndex = 3;
            this.lbKq.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.grbOps);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbOps.ResumeLayout(false);
            this.grbOps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.GroupBox grbOps;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Label lbKq;
    }
}


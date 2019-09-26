namespace E03
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCheese = new System.Windows.Forms.RadioButton();
            this.rdVeg = new System.Windows.Forms.RadioButton();
            this.rdChinese = new System.Windows.Forms.RadioButton();
            this.rdItalian = new System.Windows.Forms.RadioButton();
            this.rdVegetable = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecipe = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "YUMMY PIZZA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdVegetable);
            this.groupBox1.Controls.Add(this.rdItalian);
            this.groupBox1.Controls.Add(this.rdChinese);
            this.groupBox1.Controls.Add(this.rdVeg);
            this.groupBox1.Controls.Add(this.rdCheese);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Pizza";
            // 
            // rdCheese
            // 
            this.rdCheese.AutoSize = true;
            this.rdCheese.Location = new System.Drawing.Point(31, 41);
            this.rdCheese.Name = "rdCheese";
            this.rdCheese.Size = new System.Drawing.Size(117, 23);
            this.rdCheese.TabIndex = 0;
            this.rdCheese.TabStop = true;
            this.rdCheese.Text = "Cheese Pizza";
            this.rdCheese.UseVisualStyleBackColor = true;
            this.rdCheese.CheckedChanged += new System.EventHandler(this.rdCheese_CheckedChanged);
            // 
            // rdVeg
            // 
            this.rdVeg.AutoSize = true;
            this.rdVeg.Location = new System.Drawing.Point(31, 88);
            this.rdVeg.Name = "rdVeg";
            this.rdVeg.Size = new System.Drawing.Size(153, 23);
            this.rdVeg.TabIndex = 1;
            this.rdVeg.TabStop = true;
            this.rdVeg.Text = "Veg Crunchy Pizza";
            this.rdVeg.UseVisualStyleBackColor = true;
            this.rdVeg.CheckedChanged += new System.EventHandler(this.rdVeg_CheckedChanged);
            // 
            // rdChinese
            // 
            this.rdChinese.AutoSize = true;
            this.rdChinese.Location = new System.Drawing.Point(31, 140);
            this.rdChinese.Name = "rdChinese";
            this.rdChinese.Size = new System.Drawing.Size(122, 23);
            this.rdChinese.TabIndex = 2;
            this.rdChinese.TabStop = true;
            this.rdChinese.Text = "Chinese Pizza";
            this.rdChinese.UseVisualStyleBackColor = true;
            this.rdChinese.CheckedChanged += new System.EventHandler(this.rdChinese_CheckedChanged);
            // 
            // rdItalian
            // 
            this.rdItalian.AutoSize = true;
            this.rdItalian.Location = new System.Drawing.Point(31, 193);
            this.rdItalian.Name = "rdItalian";
            this.rdItalian.Size = new System.Drawing.Size(109, 23);
            this.rdItalian.TabIndex = 3;
            this.rdItalian.TabStop = true;
            this.rdItalian.Text = "Italian Pizza";
            this.rdItalian.UseVisualStyleBackColor = true;
            this.rdItalian.CheckedChanged += new System.EventHandler(this.rdItalian_CheckedChanged);
            // 
            // rdVegetable
            // 
            this.rdVegetable.AutoSize = true;
            this.rdVegetable.Location = new System.Drawing.Point(31, 240);
            this.rdVegetable.Name = "rdVegetable";
            this.rdVegetable.Size = new System.Drawing.Size(133, 23);
            this.rdVegetable.TabIndex = 4;
            this.rdVegetable.TabStop = true;
            this.rdVegetable.Text = "Vegetable Pizza";
            this.rdVegetable.UseVisualStyleBackColor = true;
            this.rdVegetable.CheckedChanged += new System.EventHandler(this.rdVegetable_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(261, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 204);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipe :";
            // 
            // lbRecipe
            // 
            this.lbRecipe.FormattingEnabled = true;
            this.lbRecipe.Location = new System.Drawing.Point(497, 122);
            this.lbRecipe.Name = "lbRecipe";
            this.lbRecipe.ScrollAlwaysVisible = true;
            this.lbRecipe.Size = new System.Drawing.Size(271, 95);
            this.lbRecipe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredients :";
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.Location = new System.Drawing.Point(497, 315);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.ScrollAlwaysVisible = true;
            this.lbIngredients.Size = new System.Drawing.Size(271, 108);
            this.lbIngredients.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRecipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdVegetable;
        private System.Windows.Forms.RadioButton rdItalian;
        private System.Windows.Forms.RadioButton rdChinese;
        private System.Windows.Forms.RadioButton rdVeg;
        private System.Windows.Forms.RadioButton rdCheese;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbIngredients;
    }
}
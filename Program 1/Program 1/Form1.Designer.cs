namespace Program_1
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
            this.calculateBut = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelColors = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCoats = new System.Windows.Forms.Label();
            this.labelMural = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalArea = new System.Windows.Forms.Label();
            this.PaintingCost = new System.Windows.Forms.Label();
            this.CoatsCost = new System.Windows.Forms.Label();
            this.LaborCost = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.colorsBox = new System.Windows.Forms.TextBox();
            this.paintBox = new System.Windows.Forms.TextBox();
            this.CoatsBox = new System.Windows.Forms.TextBox();
            this.lightBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateBut
            // 
            this.calculateBut.Location = new System.Drawing.Point(63, 269);
            this.calculateBut.Name = "calculateBut";
            this.calculateBut.Size = new System.Drawing.Size(75, 23);
            this.calculateBut.TabIndex = 0;
            this.calculateBut.Text = "Calculate!";
            this.calculateBut.UseVisualStyleBackColor = true;
            this.calculateBut.Click += new System.EventHandler(this.calculateBut_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Location = new System.Drawing.Point(91, 19);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(162, 13);
            this.tittle.TabIndex = 1;
            this.tittle.Text = "Welcome to My mural Calculator!";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(31, 46);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(107, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Enter the width (in ft):";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(31, 76);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(111, 13);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Enter the length (in ft):";
            this.labelLength.Click += new System.EventHandler(this.labelLength_Click);
            // 
            // labelColors
            // 
            this.labelColors.AutoSize = true;
            this.labelColors.Location = new System.Drawing.Point(31, 106);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(90, 13);
            this.labelColors.TabIndex = 4;
            this.labelColors.Text = "Number of colors:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(31, 136);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(73, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price of Paint:";
            // 
            // labelCoats
            // 
            this.labelCoats.AutoSize = true;
            this.labelCoats.Location = new System.Drawing.Point(31, 166);
            this.labelCoats.Name = "labelCoats";
            this.labelCoats.Size = new System.Drawing.Size(125, 13);
            this.labelCoats.TabIndex = 6;
            this.labelCoats.Text = "Number of Coats (1 or 2):";
            // 
            // labelMural
            // 
            this.labelMural.AutoSize = true;
            this.labelMural.Location = new System.Drawing.Point(31, 196);
            this.labelMural.Name = "labelMural";
            this.labelMural.Size = new System.Drawing.Size(169, 13);
            this.labelMural.TabIndex = 7;
            this.labelMural.Text = "Illuminate Mural? (1 = Yes, 0 =No):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Area in sq. ft:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Painting Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Coats Cost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Labor Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total Cost:";
            // 
            // TotalArea
            // 
            this.TotalArea.AutoSize = true;
            this.TotalArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalArea.Location = new System.Drawing.Point(349, 237);
            this.TotalArea.MinimumSize = new System.Drawing.Size(70, 10);
            this.TotalArea.Name = "TotalArea";
            this.TotalArea.Size = new System.Drawing.Size(70, 15);
            this.TotalArea.TabIndex = 13;
            this.TotalArea.Click += new System.EventHandler(this.totalArea_Click);
            // 
            // PaintingCost
            // 
            this.PaintingCost.AutoSize = true;
            this.PaintingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintingCost.Location = new System.Drawing.Point(349, 269);
            this.PaintingCost.MinimumSize = new System.Drawing.Size(70, 10);
            this.PaintingCost.Name = "PaintingCost";
            this.PaintingCost.Size = new System.Drawing.Size(70, 15);
            this.PaintingCost.TabIndex = 14;
            // 
            // CoatsCost
            // 
            this.CoatsCost.AutoSize = true;
            this.CoatsCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoatsCost.Location = new System.Drawing.Point(349, 301);
            this.CoatsCost.MinimumSize = new System.Drawing.Size(70, 10);
            this.CoatsCost.Name = "CoatsCost";
            this.CoatsCost.Size = new System.Drawing.Size(70, 15);
            this.CoatsCost.TabIndex = 15;
            // 
            // LaborCost
            // 
            this.LaborCost.AutoSize = true;
            this.LaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborCost.Location = new System.Drawing.Point(349, 333);
            this.LaborCost.MinimumSize = new System.Drawing.Size(70, 10);
            this.LaborCost.Name = "LaborCost";
            this.LaborCost.Size = new System.Drawing.Size(70, 15);
            this.LaborCost.TabIndex = 16;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCost.Location = new System.Drawing.Point(349, 365);
            this.TotalCost.MinimumSize = new System.Drawing.Size(70, 10);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(70, 15);
            this.TotalCost.TabIndex = 17;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(206, 39);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 18;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(206, 69);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 19;
            // 
            // colorsBox
            // 
            this.colorsBox.Location = new System.Drawing.Point(206, 99);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(100, 20);
            this.colorsBox.TabIndex = 20;
            // 
            // paintBox
            // 
            this.paintBox.Location = new System.Drawing.Point(206, 129);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(100, 20);
            this.paintBox.TabIndex = 21;
            // 
            // CoatsBox
            // 
            this.CoatsBox.Location = new System.Drawing.Point(206, 159);
            this.CoatsBox.Name = "CoatsBox";
            this.CoatsBox.Size = new System.Drawing.Size(100, 20);
            this.CoatsBox.TabIndex = 22;
            // 
            // lightBox
            // 
            this.lightBox.Location = new System.Drawing.Point(206, 189);
            this.lightBox.Name = "lightBox";
            this.lightBox.Size = new System.Drawing.Size(100, 20);
            this.lightBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 396);
            this.Controls.Add(this.lightBox);
            this.Controls.Add(this.CoatsBox);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.colorsBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.LaborCost);
            this.Controls.Add(this.CoatsCost);
            this.Controls.Add(this.PaintingCost);
            this.Controls.Add(this.TotalArea);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMural);
            this.Controls.Add(this.labelCoats);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelColors);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.calculateBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBut;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelColors;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCoats;
        private System.Windows.Forms.Label labelMural;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalArea;
        private System.Windows.Forms.Label PaintingCost;
        private System.Windows.Forms.Label CoatsCost;
        private System.Windows.Forms.Label LaborCost;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox colorsBox;
        private System.Windows.Forms.TextBox paintBox;
        private System.Windows.Forms.TextBox CoatsBox;
        private System.Windows.Forms.TextBox lightBox;
    }
}


namespace AreaPerimRec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            txtArea = new TextBox();
            btnCalculate = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPerimeter = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 29);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 0;
            label1.Text = "AREA AND PERIMETER CALCULATOR OF A RECTANGLE";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(64, 84);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(245, 84);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 2;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(540, 84);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(147, 181);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(130, 53);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 123);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "AREA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 228);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "PERIM";
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(540, 181);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(100, 23);
            txtPerimeter.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 136);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "WIDTH";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 136);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "HEIGTH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPerimeter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCalculate);
            Controls.Add(txtArea);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private TextBox txtArea;
        private Button btnCalculate;
        private Label label2;
        private Label label3;
        private TextBox txtPerimeter;
        private Label label4;
        private Label label5;
    }
}

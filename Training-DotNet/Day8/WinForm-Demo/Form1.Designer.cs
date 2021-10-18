
namespace WinForm_Demo
{
    partial class form_calculator
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
            this.lbl_calculatorTitle = new System.Windows.Forms.Label();
            this.lbl_firstNumber = new System.Windows.Forms.Label();
            this.lbl_secondNumber = new System.Windows.Forms.Label();
            this.txt_firstNumber = new System.Windows.Forms.TextBox();
            this.txt_secondNumber = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_difference = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_quotient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_calculatorTitle
            // 
            this.lbl_calculatorTitle.AutoSize = true;
            this.lbl_calculatorTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_calculatorTitle.Location = new System.Drawing.Point(139, 9);
            this.lbl_calculatorTitle.Name = "lbl_calculatorTitle";
            this.lbl_calculatorTitle.Size = new System.Drawing.Size(199, 50);
            this.lbl_calculatorTitle.TabIndex = 0;
            this.lbl_calculatorTitle.Text = "Calculator";
            // 
            // lbl_firstNumber
            // 
            this.lbl_firstNumber.AutoSize = true;
            this.lbl_firstNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_firstNumber.Location = new System.Drawing.Point(91, 79);
            this.lbl_firstNumber.Name = "lbl_firstNumber";
            this.lbl_firstNumber.Size = new System.Drawing.Size(94, 20);
            this.lbl_firstNumber.TabIndex = 1;
            this.lbl_firstNumber.Text = "First Number";
            // 
            // lbl_secondNumber
            // 
            this.lbl_secondNumber.AutoSize = true;
            this.lbl_secondNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_secondNumber.Location = new System.Drawing.Point(91, 122);
            this.lbl_secondNumber.Name = "lbl_secondNumber";
            this.lbl_secondNumber.Size = new System.Drawing.Size(116, 20);
            this.lbl_secondNumber.TabIndex = 2;
            this.lbl_secondNumber.Text = "Second Number";
            // 
            // txt_firstNumber
            // 
            this.txt_firstNumber.Location = new System.Drawing.Point(255, 80);
            this.txt_firstNumber.Name = "txt_firstNumber";
            this.txt_firstNumber.Size = new System.Drawing.Size(100, 23);
            this.txt_firstNumber.TabIndex = 3;
            // 
            // txt_secondNumber
            // 
            this.txt_secondNumber.Location = new System.Drawing.Point(255, 119);
            this.txt_secondNumber.Name = "txt_secondNumber";
            this.txt_secondNumber.Size = new System.Drawing.Size(100, 23);
            this.txt_secondNumber.TabIndex = 4;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(132, 180);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(255, 180);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(51, 228);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(40, 15);
            this.lbl_sum.TabIndex = 7;
            this.lbl_sum.Text = "Sum : ";
            // 
            // lbl_difference
            // 
            this.lbl_difference.AutoSize = true;
            this.lbl_difference.Location = new System.Drawing.Point(139, 228);
            this.lbl_difference.Name = "lbl_difference";
            this.lbl_difference.Size = new System.Drawing.Size(70, 15);
            this.lbl_difference.TabIndex = 8;
            this.lbl_difference.Text = "Difference : ";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(255, 228);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(58, 15);
            this.lbl_product.TabIndex = 9;
            this.lbl_product.Text = "Product : ";
            // 
            // lbl_quotient
            // 
            this.lbl_quotient.AutoSize = true;
            this.lbl_quotient.Location = new System.Drawing.Point(353, 228);
            this.lbl_quotient.Name = "lbl_quotient";
            this.lbl_quotient.Size = new System.Drawing.Size(60, 15);
            this.lbl_quotient.TabIndex = 10;
            this.lbl_quotient.Text = "Quotient :";
            // 
            // form_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lbl_quotient);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.lbl_difference);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_secondNumber);
            this.Controls.Add(this.txt_firstNumber);
            this.Controls.Add(this.lbl_secondNumber);
            this.Controls.Add(this.lbl_firstNumber);
            this.Controls.Add(this.lbl_calculatorTitle);
            this.Name = "form_calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_calculatorTitle;
        private System.Windows.Forms.Label lbl_firstNumber;
        private System.Windows.Forms.Label lbl_secondNumber;
        private System.Windows.Forms.TextBox txt_firstNumber;
        private System.Windows.Forms.TextBox txt_secondNumber;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_difference;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_quotient;
    }
}
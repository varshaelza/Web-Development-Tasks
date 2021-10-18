namespace SOTILoginApplication.Employee_Forms
{
    partial class form_CheckEmployee
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
            this.lbl_empNo = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.lbl_empDesig = new System.Windows.Forms.Label();
            this.lbl_empSal = new System.Windows.Forms.Label();
            this.lbl_checkEmployee = new System.Windows.Forms.Label();
            this.txt_empNo = new System.Windows.Forms.TextBox();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.txt_empDesig = new System.Windows.Forms.TextBox();
            this.txt_empSal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_empNo
            // 
            this.lbl_empNo.AutoSize = true;
            this.lbl_empNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empNo.Location = new System.Drawing.Point(79, 66);
            this.lbl_empNo.Name = "lbl_empNo";
            this.lbl_empNo.Size = new System.Drawing.Size(121, 16);
            this.lbl_empNo.TabIndex = 0;
            this.lbl_empNo.Text = "Employee Number";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empName.Location = new System.Drawing.Point(79, 103);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(110, 16);
            this.lbl_empName.TabIndex = 1;
            this.lbl_empName.Text = "Employee Name";
            // 
            // lbl_empDesig
            // 
            this.lbl_empDesig.AutoSize = true;
            this.lbl_empDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empDesig.Location = new System.Drawing.Point(79, 143);
            this.lbl_empDesig.Name = "lbl_empDesig";
            this.lbl_empDesig.Size = new System.Drawing.Size(145, 16);
            this.lbl_empDesig.TabIndex = 2;
            this.lbl_empDesig.Text = "Employee Designation";
            // 
            // lbl_empSal
            // 
            this.lbl_empSal.AutoSize = true;
            this.lbl_empSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empSal.Location = new System.Drawing.Point(79, 179);
            this.lbl_empSal.Name = "lbl_empSal";
            this.lbl_empSal.Size = new System.Drawing.Size(112, 16);
            this.lbl_empSal.TabIndex = 3;
            this.lbl_empSal.Text = "Employee Salary";
            // 
            // lbl_checkEmployee
            // 
            this.lbl_checkEmployee.AutoSize = true;
            this.lbl_checkEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkEmployee.Location = new System.Drawing.Point(129, 9);
            this.lbl_checkEmployee.Name = "lbl_checkEmployee";
            this.lbl_checkEmployee.Size = new System.Drawing.Size(233, 31);
            this.lbl_checkEmployee.TabIndex = 4;
            this.lbl_checkEmployee.Text = "Check Employee";
            // 
            // txt_empNo
            // 
            this.txt_empNo.Location = new System.Drawing.Point(246, 62);
            this.txt_empNo.Name = "txt_empNo";
            this.txt_empNo.Size = new System.Drawing.Size(100, 20);
            this.txt_empNo.TabIndex = 5;
            this.txt_empNo.Leave += new System.EventHandler(this.txt_empNo_Leave);
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(246, 99);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(100, 20);
            this.txt_empName.TabIndex = 6;
            // 
            // txt_empDesig
            // 
            this.txt_empDesig.Location = new System.Drawing.Point(246, 139);
            this.txt_empDesig.Name = "txt_empDesig";
            this.txt_empDesig.Size = new System.Drawing.Size(100, 20);
            this.txt_empDesig.TabIndex = 7;
            // 
            // txt_empSal
            // 
            this.txt_empSal.Location = new System.Drawing.Point(246, 179);
            this.txt_empSal.Name = "txt_empSal";
            this.txt_empSal.Size = new System.Drawing.Size(100, 20);
            this.txt_empSal.TabIndex = 8;
            // 
            // form_CheckEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.txt_empSal);
            this.Controls.Add(this.txt_empDesig);
            this.Controls.Add(this.txt_empName);
            this.Controls.Add(this.txt_empNo);
            this.Controls.Add(this.lbl_checkEmployee);
            this.Controls.Add(this.lbl_empSal);
            this.Controls.Add(this.lbl_empDesig);
            this.Controls.Add(this.lbl_empName);
            this.Controls.Add(this.lbl_empNo);
            this.Name = "form_CheckEmployee";
            this.Text = "Check Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_empNo;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.Label lbl_empDesig;
        private System.Windows.Forms.Label lbl_empSal;
        private System.Windows.Forms.Label lbl_checkEmployee;
        private System.Windows.Forms.TextBox txt_empNo;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.TextBox txt_empDesig;
        private System.Windows.Forms.TextBox txt_empSal;
    }
}
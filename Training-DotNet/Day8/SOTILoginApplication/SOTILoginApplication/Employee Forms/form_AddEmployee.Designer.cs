namespace SOTILoginApplication.Employee_Forms
{
    partial class form_AddEmployee
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
            this.lbl_addEmp = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.txt_empSal = new System.Windows.Forms.TextBox();
            this.lbl_empDesig = new System.Windows.Forms.Label();
            this.lbl_empSal = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_empDesig = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_addEmp
            // 
            this.lbl_addEmp.AutoSize = true;
            this.lbl_addEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addEmp.Location = new System.Drawing.Point(113, -2);
            this.lbl_addEmp.Name = "lbl_addEmp";
            this.lbl_addEmp.Size = new System.Drawing.Size(262, 31);
            this.lbl_addEmp.TabIndex = 0;
            this.lbl_addEmp.Text = "Add new Employee";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empName.Location = new System.Drawing.Point(94, 48);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(110, 16);
            this.lbl_empName.TabIndex = 1;
            this.lbl_empName.Text = "Employee name ";
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(254, 48);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(121, 20);
            this.txt_empName.TabIndex = 2;
            // 
            // txt_empSal
            // 
            this.txt_empSal.Location = new System.Drawing.Point(254, 158);
            this.txt_empSal.Name = "txt_empSal";
            this.txt_empSal.Size = new System.Drawing.Size(121, 20);
            this.txt_empSal.TabIndex = 4;
            // 
            // lbl_empDesig
            // 
            this.lbl_empDesig.AutoSize = true;
            this.lbl_empDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empDesig.Location = new System.Drawing.Point(94, 104);
            this.lbl_empDesig.Name = "lbl_empDesig";
            this.lbl_empDesig.Size = new System.Drawing.Size(145, 16);
            this.lbl_empDesig.TabIndex = 5;
            this.lbl_empDesig.Text = "Employee Designation";
            // 
            // lbl_empSal
            // 
            this.lbl_empSal.AutoSize = true;
            this.lbl_empSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empSal.Location = new System.Drawing.Point(94, 165);
            this.lbl_empSal.Name = "lbl_empSal";
            this.lbl_empSal.Size = new System.Drawing.Size(112, 16);
            this.lbl_empSal.TabIndex = 6;
            this.lbl_empSal.Text = "Employee Salary";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(155, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(254, 217);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_empDesig
            // 
            this.txt_empDesig.FormattingEnabled = true;
            this.txt_empDesig.Items.AddRange(new object[] {
            "Jr.Developer",
            "Sr,.Developer",
            "Asst.Developer",
            "Jr.Manager",
            "Sr.Manager",
            "Asst.Manager",
            "Client.HR"});
            this.txt_empDesig.Location = new System.Drawing.Point(254, 103);
            this.txt_empDesig.Name = "txt_empDesig";
            this.txt_empDesig.Size = new System.Drawing.Size(121, 21);
            this.txt_empDesig.TabIndex = 9;
            this.txt_empDesig.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // form_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.txt_empDesig);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_empSal);
            this.Controls.Add(this.lbl_empDesig);
            this.Controls.Add(this.txt_empSal);
            this.Controls.Add(this.txt_empName);
            this.Controls.Add(this.lbl_empName);
            this.Controls.Add(this.lbl_addEmp);
            this.Name = "form_AddEmployee";
            this.Text = "Add new Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addEmp;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.TextBox txt_empSal;
        private System.Windows.Forms.Label lbl_empDesig;
        private System.Windows.Forms.Label lbl_empSal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox txt_empDesig;
    }
}
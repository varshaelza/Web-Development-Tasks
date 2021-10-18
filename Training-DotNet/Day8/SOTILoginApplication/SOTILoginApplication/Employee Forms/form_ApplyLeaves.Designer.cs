namespace SOTILoginApplication.Employee_Forms
{
    partial class form_applyleaves
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
            this.lbl_applyLeave = new System.Windows.Forms.Label();
            this.lbl_empNo = new System.Windows.Forms.Label();
            this.lbl_leaves = new System.Windows.Forms.Label();
            this.txt_empNo = new System.Windows.Forms.TextBox();
            this.txt_Leaves = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_applyLeave
            // 
            this.lbl_applyLeave.AutoSize = true;
            this.lbl_applyLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applyLeave.Location = new System.Drawing.Point(170, 9);
            this.lbl_applyLeave.Name = "lbl_applyLeave";
            this.lbl_applyLeave.Size = new System.Drawing.Size(174, 31);
            this.lbl_applyLeave.TabIndex = 0;
            this.lbl_applyLeave.Text = "Apply Leave";
            // 
            // lbl_empNo
            // 
            this.lbl_empNo.AutoSize = true;
            this.lbl_empNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empNo.Location = new System.Drawing.Point(91, 71);
            this.lbl_empNo.Name = "lbl_empNo";
            this.lbl_empNo.Size = new System.Drawing.Size(121, 16);
            this.lbl_empNo.TabIndex = 1;
            this.lbl_empNo.Text = "Employee Number";
            // 
            // lbl_leaves
            // 
            this.lbl_leaves.AutoSize = true;
            this.lbl_leaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaves.Location = new System.Drawing.Point(91, 131);
            this.lbl_leaves.Name = "lbl_leaves";
            this.lbl_leaves.Size = new System.Drawing.Size(177, 16);
            this.lbl_leaves.TabIndex = 2;
            this.lbl_leaves.Text = "Number of Leaves Required";
            // 
            // txt_empNo
            // 
            this.txt_empNo.Location = new System.Drawing.Point(274, 70);
            this.txt_empNo.Name = "txt_empNo";
            this.txt_empNo.Size = new System.Drawing.Size(100, 20);
            this.txt_empNo.TabIndex = 3;
            // 
            // txt_Leaves
            // 
            this.txt_Leaves.Location = new System.Drawing.Point(274, 131);
            this.txt_Leaves.Name = "txt_Leaves";
            this.txt_Leaves.Size = new System.Drawing.Size(100, 20);
            this.txt_Leaves.TabIndex = 4;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(176, 197);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(274, 197);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // form_applyleaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_Leaves);
            this.Controls.Add(this.txt_empNo);
            this.Controls.Add(this.lbl_leaves);
            this.Controls.Add(this.lbl_empNo);
            this.Controls.Add(this.lbl_applyLeave);
            this.Name = "form_applyleaves";
            this.Text = "Apply Leaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_applyLeave;
        private System.Windows.Forms.Label lbl_empNo;
        private System.Windows.Forms.Label lbl_leaves;
        private System.Windows.Forms.TextBox txt_empNo;
        private System.Windows.Forms.TextBox txt_Leaves;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_reset;
    }
}
namespace SOTILoginApplication.Employee_Forms
{
    partial class form_GiveBonus
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
            this.lbl_givebonus = new System.Windows.Forms.Label();
            this.lbl_empNo = new System.Windows.Forms.Label();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.txt_empNo = new System.Windows.Forms.TextBox();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_givebonus
            // 
            this.lbl_givebonus.AutoSize = true;
            this.lbl_givebonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_givebonus.Location = new System.Drawing.Point(159, 9);
            this.lbl_givebonus.Name = "lbl_givebonus";
            this.lbl_givebonus.Size = new System.Drawing.Size(164, 31);
            this.lbl_givebonus.TabIndex = 0;
            this.lbl_givebonus.Text = "Give Bonus";
            this.lbl_givebonus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_empNo
            // 
            this.lbl_empNo.AutoSize = true;
            this.lbl_empNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empNo.Location = new System.Drawing.Point(119, 85);
            this.lbl_empNo.Name = "lbl_empNo";
            this.lbl_empNo.Size = new System.Drawing.Size(121, 16);
            this.lbl_empNo.TabIndex = 1;
            this.lbl_empNo.Text = "Employee Number";
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.AutoSize = true;
            this.lbl_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonus.Location = new System.Drawing.Point(121, 154);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(119, 16);
            this.lbl_bonus.TabIndex = 2;
            this.lbl_bonus.Text = "Bonus Percentage";
            // 
            // txt_empNo
            // 
            this.txt_empNo.Location = new System.Drawing.Point(246, 84);
            this.txt_empNo.Name = "txt_empNo";
            this.txt_empNo.Size = new System.Drawing.Size(100, 20);
            this.txt_empNo.TabIndex = 3;
            // 
            // txt_bonus
            // 
            this.txt_bonus.Location = new System.Drawing.Point(246, 150);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(100, 20);
            this.txt_bonus.TabIndex = 4;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(148, 202);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(246, 202);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // form_GiveBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.txt_empNo);
            this.Controls.Add(this.lbl_bonus);
            this.Controls.Add(this.lbl_empNo);
            this.Controls.Add(this.lbl_givebonus);
            this.Name = "form_GiveBonus";
            this.Text = "Give Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_givebonus;
        private System.Windows.Forms.Label lbl_empNo;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.TextBox txt_empNo;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_reset;
    }
}
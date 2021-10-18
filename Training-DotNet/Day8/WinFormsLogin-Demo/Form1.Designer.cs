
namespace WinFormsLogin_Demo
{
    partial class form_login
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_passWord = new System.Windows.Forms.Label();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.flowlayout_login = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.Location = new System.Drawing.Point(158, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(196, 45);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "SOTI LOGIN";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_userName.Location = new System.Drawing.Point(139, 79);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(75, 20);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "Username";
            // 
            // lbl_passWord
            // 
            this.lbl_passWord.AutoSize = true;
            this.lbl_passWord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_passWord.Location = new System.Drawing.Point(139, 128);
            this.lbl_passWord.Name = "lbl_passWord";
            this.lbl_passWord.Size = new System.Drawing.Size(70, 20);
            this.lbl_passWord.TabIndex = 2;
            this.lbl_passWord.Text = "Password";
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(279, 129);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.PasswordChar = '*';
            this.txt_passWord.Size = new System.Drawing.Size(100, 23);
            this.txt_passWord.TabIndex = 3;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(279, 80);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 23);
            this.txt_userName.TabIndex = 4;
            this.txt_userName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(172, 214);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(279, 214);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // flowlayout_login
            // 
            this.flowlayout_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowlayout_login.Location = new System.Drawing.Point(126, 57);
            this.flowlayout_login.Name = "flowlayout_login";
            this.flowlayout_login.Size = new System.Drawing.Size(265, 126);
            this.flowlayout_login.TabIndex = 7;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_passWord);
            this.Controls.Add(this.lbl_passWord);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.flowlayout_login);
            this.Name = "form_login";
            this.Text = "SOTI Login";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_passWord;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.FlowLayoutPanel flowlayout_login;
    }
}


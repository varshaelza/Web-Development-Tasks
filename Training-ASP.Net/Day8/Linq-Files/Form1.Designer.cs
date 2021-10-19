namespace Linq_Files
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
            this.btn_Files = new System.Windows.Forms.Button();
            this.btn_Folders = new System.Windows.Forms.Button();
            this.grd_Grid = new System.Windows.Forms.DataGridView();
            this.lbl_Filecount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Files
            // 
            this.btn_Files.Location = new System.Drawing.Point(238, 12);
            this.btn_Files.Name = "btn_Files";
            this.btn_Files.Size = new System.Drawing.Size(75, 23);
            this.btn_Files.TabIndex = 0;
            this.btn_Files.Text = "Files";
            this.btn_Files.UseVisualStyleBackColor = true;
            this.btn_Files.Click += new System.EventHandler(this.btn_Files_Click);
            // 
            // btn_Folders
            // 
            this.btn_Folders.Location = new System.Drawing.Point(517, 12);
            this.btn_Folders.Name = "btn_Folders";
            this.btn_Folders.Size = new System.Drawing.Size(75, 23);
            this.btn_Folders.TabIndex = 1;
            this.btn_Folders.Text = "Folders";
            this.btn_Folders.UseVisualStyleBackColor = true;
            this.btn_Folders.Click += new System.EventHandler(this.btn_Folders_Click);
            // 
            // grd_Grid
            // 
            this.grd_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Grid.Location = new System.Drawing.Point(165, 67);
            this.grd_Grid.Name = "grd_Grid";
            this.grd_Grid.Size = new System.Drawing.Size(504, 319);
            this.grd_Grid.TabIndex = 2;
            // 
            // lbl_Filecount
            // 
            this.lbl_Filecount.AutoSize = true;
            this.lbl_Filecount.Location = new System.Drawing.Point(276, 38);
            this.lbl_Filecount.Name = "lbl_Filecount";
            this.lbl_Filecount.Size = new System.Drawing.Size(0, 13);
            this.lbl_Filecount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Filecount);
            this.Controls.Add(this.grd_Grid);
            this.Controls.Add(this.btn_Folders);
            this.Controls.Add(this.btn_Files);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grd_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Files;
        private System.Windows.Forms.Button btn_Folders;
        private System.Windows.Forms.DataGridView grd_Grid;
        private System.Windows.Forms.Label lbl_Filecount;
    }
}


namespace TransactionsManagement
{
    partial class TransferAmount
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
            this.lbl_sender = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_transfer = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_receiver = new System.Windows.Forms.TextBox();
            this.txt_sender = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sender.Location = new System.Drawing.Point(208, 144);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(115, 15);
            this.lbl_sender.TabIndex = 0;
            this.lbl_sender.Text = "Sender Account .No";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receiver.Location = new System.Drawing.Point(208, 209);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(123, 15);
            this.lbl_receiver.TabIndex = 1;
            this.lbl_receiver.Text = "Receiver Account .No";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(208, 272);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(49, 15);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Text = "Amount";
            // 
            // lbl_transfer
            // 
            this.lbl_transfer.AutoSize = true;
            this.lbl_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transfer.Location = new System.Drawing.Point(265, 43);
            this.lbl_transfer.Name = "lbl_transfer";
            this.lbl_transfer.Size = new System.Drawing.Size(216, 31);
            this.lbl_transfer.TabIndex = 3;
            this.lbl_transfer.Text = "Transfer Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(430, 267);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 4;
            // 
            // txt_receiver
            // 
            this.txt_receiver.Location = new System.Drawing.Point(430, 204);
            this.txt_receiver.Name = "txt_receiver";
            this.txt_receiver.Size = new System.Drawing.Size(100, 20);
            this.txt_receiver.TabIndex = 5;
            // 
            // txt_sender
            // 
            this.txt_sender.Location = new System.Drawing.Point(430, 143);
            this.txt_sender.Name = "txt_sender";
            this.txt_sender.Size = new System.Drawing.Size(100, 20);
            this.txt_sender.TabIndex = 6;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(339, 349);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(92, 32);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Transfer";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // TransferAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_sender);
            this.Controls.Add(this.txt_receiver);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_transfer);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.lbl_sender);
            this.Name = "TransferAmount";
            this.Text = "TransferAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_transfer;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_receiver;
        private System.Windows.Forms.TextBox txt_sender;
        private System.Windows.Forms.Button btn_submit;
    }
}
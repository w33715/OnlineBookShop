namespace Send_EMails_CSharp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSendMailCSarp = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Send_EMails_CSharp.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(107, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSendMailCSarp
            // 
            this.lblSendMailCSarp.AutoSize = true;
            this.lblSendMailCSarp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSendMailCSarp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSendMailCSarp.Location = new System.Drawing.Point(37, 113);
            this.lblSendMailCSarp.Name = "lblSendMailCSarp";
            this.lblSendMailCSarp.Size = new System.Drawing.Size(194, 30);
            this.lblSendMailCSarp.TabIndex = 1;
            this.lblSendMailCSarp.Text = "Send E-Mail in C#";
            // 
            // txtEMail
            // 
            this.txtEMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEMail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEMail.Location = new System.Drawing.Point(37, 159);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(202, 22);
            this.txtEMail.TabIndex = 2;
            this.txtEMail.Text = "EMail";
            this.txtEMail.Enter += new System.EventHandler(this.txtEMail_Enter);
            this.txtEMail.Leave += new System.EventHandler(this.txtEMail_Leave);
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSubject.Location = new System.Drawing.Point(37, 195);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(202, 22);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.Text = "Subject";
            this.txtSubject.Enter += new System.EventHandler(this.txtSubject_Enter);
            this.txtSubject.Leave += new System.EventHandler(this.txtSubject_Leave);
            // 
            // txtMess
            // 
            this.txtMess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMess.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMess.Location = new System.Drawing.Point(37, 230);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(202, 81);
            this.txtMess.TabIndex = 2;
            this.txtMess.Text = "Message";
            this.txtMess.Enter += new System.EventHandler(this.txtMess_Enter);
            this.txtMess.Leave += new System.EventHandler(this.txtMess_Leave);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(37, 336);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(202, 43);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(273, 501);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.lblSendMailCSarp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSendMailCSarp;
        private TextBox txtEMail;
        private TextBox txtSubject;
        private TextBox txtMess;
        private Button btnSend;
    }
}
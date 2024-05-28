


using System.Net.Mail;

namespace Send_EMails_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEMail_Enter(object sender, EventArgs e)
        {
            if(txtEMail.Text=="EMail")
            {
                txtEMail.Clear();
                txtEMail.ForeColor = Color.FromArgb(3, 179, 233);
            }
        }

        private void txtEMail_Leave(object sender, EventArgs e)
        {
            if (txtEMail.Text == "")
            {
                txtEMail.ForeColor = Color.FromArgb(200, 200, 200);
                txtEMail.Text = "EMail";
               
            }
        }

        private void txtSubject_Enter(object sender, EventArgs e)
        {
            if(txtSubject.Text=="Subject")
            {
                txtSubject.Clear();
                txtSubject.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSubject_Leave(object sender, EventArgs e)
        {
            if(txtSubject.Text=="")
            {
                txtSubject.ForeColor=Color.FromArgb(200, 200, 200);
                txtSubject.Text = "Subject";                
            }
        }

        private void txtMess_Enter(object sender, EventArgs e)
        {
            if(txtMess.Text=="Message")
            {
                txtMess.Clear();
                txtMess.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtMess_Leave(object sender, EventArgs e)
        {
            if(txtMess.Text=="")
            {
                txtMess.ForeColor=Color.FromArgb(200,200,200);
                txtMess.Text = "Message";               
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to, from, pass, messageBody;
            MailMessage message = new MailMessage();
            to=txtEMail.Text;
            from = "igor.dmitrienko@web.de";
            pass = "6GH5nuFC";
            messageBody=txtMess.Text;
            message.To.Add(to);
            message.From=new MailAddress(from);
            message.Body = "From : " + "<br>Message: " + messageBody;
            message.Subject = txtSubject.Text;
            message.IsBodyHtml= true;
            SmtpClient smtp = new SmtpClient("smtp.web.de");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (code == DialogResult.OK)
                {
                    txtEMail.Clear();
                    txtSubject.Clear();
                    txtMess.Clear();
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
        }
    }
}
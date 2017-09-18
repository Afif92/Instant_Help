using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace Instant_Help
{
    public partial class Send_Mail : Form
    {
        private string source = "";
        public Send_Mail()
        {
            InitializeComponent();
        }
        OpenFileDialog openFile = new OpenFileDialog();
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtBoxAttachFile.Text = openFile.SafeFileName;
                source = openFile.FileName;
            }
        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("roy.miller.1080@gmail.com");
                mail.To.Add("rasel.00x@gmail.com");
                mail.Subject =txtSubject.Text ;
                mail.Body = txtMailBody.Text ;
                if(source != "")
                {
                    Attachment att;
                    att = new Attachment(source);
                    mail.Attachments.Add(att);
                }           
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("roy.miller.1080@gmail.com","rasel.420");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                MessageBox.Show("Mail Send SuccessFully.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

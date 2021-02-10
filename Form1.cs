using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendGmailWithAttach
{
    public partial class Form1 : Form
    {
        private List<EmailData> emails2Process;
        private int currentPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tbFile.Text = openFileDialog.FileName;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            this.currentPosition = 0;
            if (ValidateFile())
            {
                myTimer.Interval = 100;
                myTimer.Start();
            }
        }

        private Boolean ValidateFile()
        {
            lblProgress.Text = "";

            List<EmailData> emails = ReadReceiversFile();
            if (!FileCheck(emails))
            {
                return false;
            }

            if (!EmailCheck())
            {
                return false;
            }


            lblProgress.Text = "Existem " + this.emails2Process.Count + " destinatários para processar";

            return true;
        }
        private Boolean IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private Boolean EmailCheck()
        {
            foreach (EmailData email in this.emails2Process)
            {
                if (! IsValidEmail(email.EmailAddress))
                {
                    MessageBox.Show("O email " + email.EmailAddress + " não é válido!");

                    return false;
                }
            }

            return true;
        }

        private Boolean FileCheck(List<EmailData> emails)
        {
            foreach(EmailData email in emails)
            {
                String baseFolder = Path.GetDirectoryName(openFileDialog.FileName);
                if (!File.Exists(baseFolder + "\\" + email.AttachFile))
                {
                    MessageBox.Show("O ficheiro " + email.AttachFile + " não existe!");
                    
                    return false;
                }
            }

            this.emails2Process = emails;

            return true;
        }

        private List<EmailData> ReadReceiversFile()
        {
            List<EmailData> emails = new List<EmailData>();
            using (StreamReader reader = new StreamReader(tbFile.Text))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    emails.Add(new EmailData(values[0], values[1]));
                }
            }
            
            return emails;
        }

        private void SendEmail(String receiver, String attachedFile)
        {
            String baseFolder = Path.GetDirectoryName(openFileDialog.FileName);

            MailAddress mailfrom = new MailAddress(tbSender.Text);
            MailAddress mailto = new MailAddress(receiver);
            MailMessage newmsg = new MailMessage(mailfrom, mailto);
            newmsg.Subject = tbSubject.Text;
            newmsg.Body = tbBody.Text;
            Attachment att = new Attachment(baseFolder + "\\" + attachedFile);
            newmsg.Attachments.Add(att);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(tbUser.Text, tbPwd.Text);
            smtp.EnableSsl = true;
            smtp.Send(newmsg);
        }

        private void btValidate_Click(object sender, EventArgs e)
        {
            if (ValidateFile())
            {
                MessageBox.Show("All good!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "";
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (this.currentPosition == 0)
            {
                myTimer.Stop();
                SendCurrentPosition();
                myTimer.Interval = int.Parse(tbDelay.Text) * 1000;
                myTimer.Start();
            }
            else
            {
                SendCurrentPosition();
            }
        }

        private void SendCurrentPosition()
        {
            EmailData emailData = this.emails2Process[this.currentPosition];
            lblProgress.Text = "A enviar " + (++this.currentPosition) + " de um total de " + this.emails2Process.Count + " registos por processar";
            //SendEmail(emailData.EmailAddress, emailData.AttachFile);
            if (this.currentPosition >= this.emails2Process.Count)
            {
                myTimer.Stop();
                MessageBox.Show("Todos os emails foram enviados!");
            }
        }
    }
}

﻿using System;
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
        private Char fieldSeparator = ';';
        private String errorLogFileName;
        private String errorRecordFileName;
        private int errorCount;
        private Logger logger;

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
            this.errorCount = 0;
            SetErrorLogFilename();
            if (ValidateFile())
            {
                this.logger = new Logger(this.fieldSeparator, this.errorLogFileName, this.errorRecordFileName);
                myTimer.Interval = 1000;
                myTimer.Start();
            }
        }

        private void SetErrorLogFilename()
        {
            String baseFolder = Path.GetDirectoryName(openFileDialog.FileName);
            String timeStamp = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") +
                DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.ToLongTimeString().Replace(':','_');
            this.errorRecordFileName = baseFolder + "\\error_records_" + timeStamp + ".csv";
            this.errorLogFileName = baseFolder + "\\error_log_" + timeStamp + ".txt";
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
                    var values = line.Split(fieldSeparator);
                    if (values.Count<String>() == 1)
                    {
                        this.fieldSeparator = ',';
                        values = line.Split(fieldSeparator);
                    }
                    emails.Add(new EmailData(values[0], values[1]));
                }
            }
            
            return emails;
        }

        private void SendEmail(String receiver, String attachedFile)
        {
            String baseFolder = Path.GetDirectoryName(openFileDialog.FileName);

            try
            {
                MailAddress mailfrom = new MailAddress(tbSender.Text);
                MailAddress mailto = new MailAddress(receiver.Replace(" ",""));
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
            catch (Exception ex)
            {
                this.errorCount++;
                this.logger.Log(receiver, attachedFile, ex);
            }
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
            String msg = "A enviar " + (++this.currentPosition) + " de um total de " + this.emails2Process.Count + " registos.";
            if (this.errorCount > 0)
            {
                msg += this.errorCount.ToString() + " erros";
            }
            lblProgress.Text = msg;
            SendEmail(emailData.EmailAddress.Trim(), emailData.AttachFile);
            if (this.currentPosition >= this.emails2Process.Count)
            {
                myTimer.Stop();
                if (this.errorCount == 0)
                {
                    MessageBox.Show("Todos os emails foram enviados com sucesso!");
                }
                else
                {
                    MessageBox.Show("Foram enviados " + 
                        (this.emails2Process.Count - this.errorCount) + 
                        " de um total de " + this.emails2Process.Count +
                        ".\r\nO ficheiro " + this.errorRecordFileName + " contém os registos não enviados!");
                }
            }
        }
    }
}

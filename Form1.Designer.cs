namespace SendGmailWithAttach
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btValidate = new System.Windows.Forms.Button();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pwd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ficheiro";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(81, 35);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(129, 20);
            this.tbUser.TabIndex = 2;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(81, 62);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(129, 20);
            this.tbPwd.TabIndex = 3;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(81, 92);
            this.tbFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(323, 20);
            this.tbFile.TabIndex = 4;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(407, 92);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(68, 19);
            this.btBrowse.TabIndex = 5;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(407, 275);
            this.btSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(68, 19);
            this.btSend.TabIndex = 10;
            this.btSend.Text = "Enviar";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(81, 9);
            this.tbSender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(129, 20);
            this.tbSender.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remetente";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(81, 122);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(395, 20);
            this.tbSubject.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Assunto";
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(81, 154);
            this.tbBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(395, 76);
            this.tbBody.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(81, 314);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProgress.Size = new System.Drawing.Size(77, 13);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "Progress Label";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(81, 275);
            this.btValidate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(68, 19);
            this.btValidate.TabIndex = 9;
            this.btValidate.Text = "Validar";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(81, 243);
            this.tbDelay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(21, 20);
            this.tbDelay.TabIndex = 8;
            this.tbDelay.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Espera (secs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mensagem";
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gmail Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer myTimer;
    }
}


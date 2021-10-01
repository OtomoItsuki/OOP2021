using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class btConfig : Form {

        private ConfigForm configform = new ConfigForm();

        private Settings setting = Settings.getInstance();

        SmtpClient smtpClient = null;
        public btConfig() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            btSend.Enabled = false;
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(setting.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                //宛先（Cc）
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }
                //宛先（Bcc）
                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                if (smtpClient == null) {
                    smtpClient = new SmtpClient();
                    smtpClient.SendCompleted += SmtpClient_SendCompleted;

                }
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                if (smtpClient.Credentials == null) {
                    smtpClient.Credentials
                      = new NetworkCredential(setting.MailAddr, setting.Pass);
                }
                smtpClient.Host = setting.Host;
                smtpClient.Port = setting.Port;
                smtpClient.EnableSsl = setting.Ssl;
                smtpClient.SendAsync(mailMessage, mailMessage);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            MailMessage msg = (MailMessage)e.UserState;
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }
            else {
                MessageBox.Show("送信完了");
            }
            btSend.Enabled = true;
        }

        //送信終了すると呼ばれるメソッド


        private void button1_Click(object sender, EventArgs e) {
            configform.ShowDialog();
            
        }
    }
}
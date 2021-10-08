using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace SendMail {
    public partial class form1 : Form {

        private ConfigForm configform = new ConfigForm();

        private Settings settings = Settings.getInstance();

        public form1() {
            InitializeComponent();
            
        }

        private void btSend_Click(object sender, EventArgs e) {
            
            btSend.Enabled = false;
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
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
                SmtpClient smtpClient = new SmtpClient();


                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                            = new NetworkCredential(settings.MailAddr, settings.Pass);

                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                string userState = "SendMail";
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                smtpClient.SendAsync(mailMessage, userState);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

                btSend.Enabled = true;
            }
        }

        //送信終了すると呼ばれるメソッド
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }
            
            else if(e.Cancelled == true){
            }
            else {

                MessageBox.Show("送信完了");
            }
            btSend.Enabled = true;
        }

        private void btConfig_Click(object sender, EventArgs e) {
            configform.ShowDialog();
            
        }

        
    }
}
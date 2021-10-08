using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class ConfigForm : Form {


        private Settings settings = Settings.getInstance();

        public ConfigForm() {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {

            tbHost.Text      = settings.sHost();    //ホスト名
            tbPort.Text      = settings.sPort();    //ポート番号
            tbSender.Text    = settings.sMailAddr();//送信元
            tbUserName.Text  = settings.sMailAddr();//ユーザー名
            tbPass.Text      = settings.sPass();    //パスワード
            cbSsl.Checked    = settings.bSsl();     //SSL

        }

        private void btOk_Click(object sender, EventArgs e) {
            btApply_Click(sender, e);
            this.Close();
        }
        
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbSender.Text,tbPass.Text,cbSsl.Checked);
        }

        private void ConfigForm_Load(object sender, EventArgs e) {

            tbHost.Text = settings.Host;    //ホスト名
            tbPort.Text = settings.Port.ToString();    //ポート番号
            tbSender.Text = settings.MailAddr;//送信元
            tbUserName.Text = settings.MailAddr;//ユーザー名
            tbPass.Text = settings.Pass;    //パスワード
            cbSsl.Checked = settings.Ssl;     //SSL

        }

    }
}

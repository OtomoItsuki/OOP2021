using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail {
    public class Settings {

        private static Settings Instance = null;

        public int Port { get; set; }       //ポート番号
        public string Host { get; set; }    //ホスト名
        public string MailAddr { get; set; }//メールアドレス
        public string Pass { get; set; }    //パスワード
        public bool Ssl { get; set; }       //SSL

        private Settings() {
            
        }
        //初期値
        public string sHost() {
            return "smtp.gmail.com";
        }
        public string sPort() {
            return 587.ToString();
        }
        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }
        public string sPass() {
            return "Infosys2021";
        }
        public bool bSsl() {
            return true;
        }
        public static Settings getInstance() {
            if (Instance == null) {
                Instance = new Settings();
            }
            return Instance;
        }
        public static void settingsSave(Settings settings) {
            var xws = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws)) {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //選択しているものが何もない状態がないようにする
            cbArea.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e) {
            //一番最初にリセットをすることで前の結果と重なって見づらくなることを防ぐ
            tbResult.Text = "";
            
            int code = 0;
            
            switch (cbArea.SelectedIndex) {
                case 0:
                    code = 4210;
                    break;
                case 1:
                    code = 4220;
                    break;
                case 2:
                    code = 4110;
                    break;
                case 3:
                    code = 4010;
                    break;
                case 4:
                    int.TryParse(tbOtherInput.Text, out code);
                    break;

                default:
                    break;
            }


            var results = GetWeatherReportFromYahoo(code);
            foreach (var s in results) {

                tbResult.Text += s +"\r\n";
            }

        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbArea.SelectedIndex == 4) {
                MessageBox.Show("表示したい地域のコードを\r\n黄色のテキストボックスに入力してください",
                    "表示したい地域のコードを入力してください", MessageBoxButtons.OK);

                //tbOtherInputがfalseならtrueにする(いるのかわからないがとりあえず)
                if (!tbOtherInput.Visible) {
                    tbOtherInput.Visible = true;
                }
            }
            else {
                if (tbOtherInput.Visible) {
                    tbOtherInput.Visible = false;
                }
            }
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}

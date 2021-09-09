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

namespace RssReader {
    public partial class Form1 : Form {
        List<string> links = new List<string>();
        List<string> descriptions = new List<string>();
        List<string> upDays = new List<string>();

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            SetRssTitle(tbUrl.Text);
        }
        private void SetRssTitle(string uri) {
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var xitems = xdoc.Root.Descendants("item");
                var nodes = xitems.Descendants("title");

                links = xitems.Descendants("link").Select(x => x.Value).ToList();
                upDays = xitems.Descendants("pubDate").Select(x => x.Value).ToList();
                descriptions = xitems.Descendants("description").Select(x => x.Value).ToList();

                foreach (var node in nodes) {
                    lbTitles.Items.Add(node.Value);
                }
                
            }
        }
        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            try {

                labelUpDay.Text = upDays[lbTitles.SelectedIndex];
                labelDesc.Text = descriptions[lbTitles.SelectedIndex];

            }
            catch (Exception) {
                
                return;
            }
            btView.Visible = true;
            var targetString = lbTitles.Items[lbTitles.SelectedIndex].ToString();

            
        }

        private void btView_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.wbBrowser.Url = new Uri(links[lbTitles.SelectedIndex]);
            form2.ShowDialog();
        }
    }
}

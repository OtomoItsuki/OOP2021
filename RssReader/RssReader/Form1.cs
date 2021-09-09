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
                var nodes = xdoc.Root.Descendants("item").Descendants("title");
                links = xdoc.Root.Descendants("item").Descendants("link").Select(x => x.Value).ToList();
                foreach (var node in nodes) {
                    lbTitles.Items.Add(node.Value);
                }
                
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var targetString = lbTitles.Items[lbTitles.SelectedIndex].ToString();

            wbBrowser.Url = new Uri(links[lbTitles.SelectedIndex]);
            
        }
    }
}

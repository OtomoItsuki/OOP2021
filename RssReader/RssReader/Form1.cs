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
        XDocument xdoc;

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            SetRssTitle(tbUrl.Text);
        }
        private void SetRssTitle(string uri) {
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(uri);

                xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    lbTitles.Items.Add(node.Value);
                }
                
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {


            var uri2 = xdoc.Root.Elements().Where(x => x.Element("title") == lbTitles.Items[lbTitles.SelectedIndex]);
            
        }
    }
}

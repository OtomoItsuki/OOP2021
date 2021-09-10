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
        IEnumerable<ItemData> items = null;

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
                items = xdoc.Root.Descendants("item").Select(x => new ItemData {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("descrption")

                });
                
        
                foreach (var item in items) {
                    lbTitles.Items.Add(item.Title);
                }
                
            }
        }
        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                
                labelPubDate.Text = (items.ToArray())[lbTitles.SelectedIndex].PubDate.ToString();
                labelDesc.Text = (items.ToArray())[lbTitles.SelectedIndex].Description;

            }
            catch (Exception) {
                
                return;
            }
            btView.Visible = true;

            
        }

        private void btView_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.wbBrowser.Url = new Uri((items.ToArray())[lbTitles.SelectedIndex].Link);
            form2.ShowDialog();
        }
    }
}

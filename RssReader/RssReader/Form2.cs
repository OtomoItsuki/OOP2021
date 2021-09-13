﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {
        
        public Form2() {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();

        }

        private void wbBrowser_CanGoBackChanged(object sender, EventArgs e) {
            btBack.Enabled = wbBrowser.CanGoBack;
        }
        private void wbBrowser_CanGoForwardChanged(object sender, EventArgs e) {
            btForward.Enabled = wbBrowser.CanGoForward;
        }

        private void btBack_MouseHover(object sender, EventArgs e) {
            hoverLabel.Text = "aiu";
            hoverLabel.Location = Cursor.Position;
        }
    }
}
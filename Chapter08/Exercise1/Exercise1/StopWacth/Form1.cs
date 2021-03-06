using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWacth {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            tm.Start();

            tm.Tick += Tm_Tick;
            
        }

        private void Tm_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            tm.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
            lbLap.Items.Clear();

        }

        private void btLap_Click(object sender, EventArgs e) {
            lbLap.Items.Insert(0,lbTimerDisp.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        string inputPath = "";
        string outputPath = "";

        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
                try {
                    var lines = File.ReadLines(inputPath).Select((s, ix) => string.Format("{0,4}:{1}", ix + 1, s)).ToArray();
                    File.WriteAllLines(outputPath, lines);
                    
                }
                catch (Exception) {

                    throw;
                }
            }
        }

        private void btSaveFile_Click_1(object sender, EventArgs e) {
            if(sfdSaveFile.ShowDialog() == DialogResult.OK) {
                outputPath = sfdSaveFile.FileName;
            }
        }
    }
}

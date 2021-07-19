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

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            int Count = 0;
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                try {
                    using (var reader = new StreamReader(ofdOpenFile.FileName,Encoding.GetEncoding("shift_jis"))) {

                        tbOutput.Text = "";
                        while (!reader.EndOfStream) {
                            var line = reader.ReadLine();
                            if (line.Contains(tbKeyWord.Text))
                                Count++;
                            //tbOutput.Text += line + "\r\n";
                        }
                        
                    }
                }
                catch (Exception) {
                    MessageBox.Show("テキストを入力してください", "エラー発生",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                tbOutput.Text = $"{tbKeyWord.Text}の個数は{Count}個";
            }
        }

        private void btAllOpen_Click(object sender, EventArgs e) {
            int Count = 0;
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                try {
                    var reader = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                    foreach (var item in reader) {
                        if (item.Contains(tbKeyWord.Text))
                            Count++;
                    }
                }
                catch (Exception) {
                    MessageBox.Show("テキストを入力してください", "エラー発生",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                tbOutput.Text = $"キーワード 「{tbKeyWord.Text}」の含まれている行は{Count}行";
            }
        }

        private void btReadLines_Click(object sender, EventArgs e) {

            int Count = 0;
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                try {
                    Count = File.ReadLines(ofdOpenFile.FileName,
                        Encoding.GetEncoding("shift_jis")).Count(s => s.Contains(tbKeyWord.Text));

                }
                catch (Exception) {
                    MessageBox.Show("テキストを入力してください", "エラー発生",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                tbOutput.Text = $"キーワード 「{tbKeyWord.Text}」の含まれている行は{Count}行";
            }
        }
    }
}

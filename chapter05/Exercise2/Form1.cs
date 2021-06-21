using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button5_2_Click(object sender, EventArgs e) {
            if (int.TryParse(inStrNum.Text, out int num)) {
                outstrNum.Text = num.ToString("#,0");
            }else if (inStrNum.Text == "") {
                
            }
            else {
                MessageBox.Show("数値文字列ではありません\n正しい数値文字列を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
                
            
        }
    }
}

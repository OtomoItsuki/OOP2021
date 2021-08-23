using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            int num1 = int.Parse(Value.Text);
            int num2 = int.Parse(Jyou.Text);

            if (!cbUsePow.Checked) {

                if (num2 >= 0) {

                    int Anser = 1;
                    for (int i = 0; i < num2; i++) {
                        Anser *= num1;
                        Result.Text = Anser.ToString();
                    }
                }
                else {
                    double Anser = 1;
                    for (int i = 0; i < num2*-1; i++) {
                        Anser /= num1;
                        Result.Text = Anser.ToString();
                    }
                }
            }
            Result.Text = Math.Pow(num1, num2).ToString();
            
        }
    }
}

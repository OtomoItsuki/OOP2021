using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで、1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            InputStrText.Text = "Jackdaws love my big sphinx of quartz";
            TextBoxReplaceFrom.Text = "big";
            textBoxReplaceTo.Text = "small";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var Count = InputStrText.Text.Count(c => c == ' ');

            TextBoxSpaceCount.Text = Count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            var ToSmallText = InputStrText.Text.Replace(TextBoxReplaceFrom.Text,textBoxReplaceTo.Text);

            TextBoxWordChange.Text = ToSmallText;
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            if (InputStrText.Text != "") {
                TextBoxWordCount.Text = InputStrText.Text.Split(' ').Length.ToString();
            }
            else {
                TextBoxWordCount.Text = "0";
            }
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {

            var Words = InputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            var Result = string.Join(",", Words);
            
            TextBoxWord4Count.Text = Result;
                
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            
            var array = InputStrText.Text.Split(' ');

            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {

                sb.Append(' '); 
                sb.Append(word);

            }

            TextBoxStrBuilder.Text = sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var birthDay = new DateTime((int)dtp.Value.Year, (int)dtp.Value.Month, (int)dtp.Value.Day);


            /*DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }
            tbOutput.Text = dow + "です";*/

            tbOutput.Text = GetAge(today, birthDay) + "歳です";

            //TimeSpan diff = DateTime.Today.Date - today.Date;
            //tbOutput.Text = diff.Days +"日間経過しています";

            var isLeapYear = DateTime.IsLeapYear(birthDay.Year);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            }
            else {
                tbLeapYear.Text = "閏年ではありません";
            }
            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }

        private int GetAge(DateTime today, DateTime birthDay) {
            var age = today.Year - birthDay.Year;
            if (today < birthDay.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}

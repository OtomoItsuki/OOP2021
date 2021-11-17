using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private string Anser;
        int clickCount;
        public MainWindow() {
            InitializeComponent();
            Random rand = new Random();
            Anser = rand.Next(1, 26).ToString();
            Button bt1 = new Button();
            bt1.Content = "テスト";
            
        }


        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            clickCount++;
            lbclickCount.Content = "クリック数:" + clickCount;
            if (button.Content.ToString() == Anser) {
                lbclearTxt.Content = "正解:" + Anser;
                MessageBox.Show("正解!");
            }
            else {
                lbclearTxt.Content = "はずれ";
            }
        }
    }
}

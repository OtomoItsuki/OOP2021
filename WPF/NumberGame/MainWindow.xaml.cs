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
        int Anser;
        public MainWindow() {
            InitializeComponent();
            Random rand = new Random();
            Anser = rand.Next(0, 25);
        }

        private void Button_Click(Button sender, RoutedEventArgs e) {
            if (sender.Content.ToString() == Anser.ToString()) {

            }
        }
    }
}

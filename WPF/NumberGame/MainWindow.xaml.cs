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
        private int Anser;
        int clickCount;

        int gridRow = 10;
        int gridColumn = 10;

        Random rand = new Random();
        List<Button> buttons = new List<Button>();
        SolidColorBrush solidButtonColor = new SolidColorBrush(Colors.Yellow);
        SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Red);
        public MainWindow() {
            InitializeComponent();

            

        }


        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            clickCount++;
            lbclickCount.Content = "クリック数:" + clickCount;
            if (int.Parse(button.Content.ToString()) == Anser) {
                lbclearTxt.Content = "正解:" + Anser;
                buttons[Anser].SetValue(BackgroundProperty, hitButtonColor);
                MessageBox.Show("正解!");
            }
            else {
                lbclearTxt.Content = "はずれ";
                buttons[int.Parse(button.Content.ToString()) - 1].SetValue(BackgroundProperty, solidButtonColor);

                if (int.Parse(button.Content.ToString()) > Anser) {

                    lbclearTxt.Content += "　これより低いです";
                }
                else {
                    lbclearTxt.Content += "　これより高いです";
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            Anser = rand.Next(1, gridRow * gridColumn);

            RowDefinition rowDefinition = new RowDefinition();
            rowDefinition.Height = new GridLength(1.0, GridUnitType.Star);
            for (int i = 0; i < gridRow; i++) {
                grWindow.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < gridColumn; i++) {
                grWindow.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < gridRow; i++) {

                for (int j = 1; j <= gridColumn; j++) {
                    Button bt = new Button();
                    bt.Content = i * gridColumn + j;
                    bt.Click += Button_Click;
                    bt.FontSize = 20;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j-1);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grWindow.Children.Add(bt));

        }
    }
}

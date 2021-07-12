using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }
        //終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //選択されているメーカーの名前を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (RadioButton rb in gbMaker.Controls) {
                if (rb.Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }

            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {

                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {

            if (!cbCarName.Items.Contains(carName)) {

                cbCarName.Items.Add(carName);
            }
        }


        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力してください");
                return;
            }
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            
            listCarReport.Insert(0,carReport);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Clear();

        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            
            //選択されたデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];
            
            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Author;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }
        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbToyota.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            if (listCarReport.Count == 0) {
                return;
            }
            listCarReport.RemoveAt(dgvRegistData.CurrentCell.RowIndex);
        }

        private void btCollect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentCell.RowIndex].UpDate(
                dtpDate.Value,
                cbAuthor.Text,
                selectedGroup(),
                cbCarName.Text,
                tbReport.Text,
                pbPicture.Image);
            dgvRegistData.Update();
        }
    }
}

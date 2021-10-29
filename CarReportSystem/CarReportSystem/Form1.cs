using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }
        //終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像の削除ボタン
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

        //データを追加するボタン
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
            //リストにデータを追加
            listCarReport.Insert(0, carReport);

            //コンボボックスに履歴を登録
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            //入力内容のリセット
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Clear();

        }
        //セルをクリックしたとき、データを入力する
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
        //メーカを選ぶボタン
        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbInport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
        }

        //削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
            if (listCarReport.Count == 0) {
                return;
            }
            if (MessageBox.Show("削除しますか?", "", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                //listCarReport.RemoveAt(dgvRegistData.CurrentCell.RowIndex);
            }


        }
        //修正ボタン
        private void btCollect_Click(object sender, EventArgs e) {
            //listCarReport[dgvRegistData.CurrentCell.RowIndex].UpDate(
            //    dtpDate.Value,
            //    cbAuthor.Text,
            //    selectedGroup(),
            //    cbCarName.Text,
            //    tbReport.Text,
            //    pbPicture.Image);

            ////コントロールの強制再描画
            //dgvRegistData.Refresh();

        }
        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) {
                return;
            }
            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
            if (!(selectedGroup() == CarReport.MakerGroup.その他)) {
                carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー

            }
            else if (carReportDataGridView.CurrentRow.Cells[3].Value.ToString() == "") {
                carReportDataGridView.CurrentRow.Cells[3].Value = CarReport.MakerGroup.その他;
            }
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);    //画像


            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202103DataSet);
#if false
            try {
                if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                    var bf = new BinaryFormatter();
                    //バイナリ形式でシリアル化
                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\r\n\r\n保存ができませんでした",
                    "エラー発生", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
#endif
        }
        //接続ボタンイベント処理
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202103DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202103DataSet.CarReport);

#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter();
                    //バイナリ形式で逆シリアル化
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む

                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);

                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\r\n\r\n正しいファイルを選んでください", "エラー発生", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //読み込んだデータを各コンボボックスに登録する

                foreach (var item in listCarReport) {

                    setCbAuthor(item.Author);
                    setCbCarName(item.CarName);
                }
                //for (int i = 0; i < dgvRegistData.RowCount; i++) {
                //    setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                //    setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                //}
            }
#endif
        }

        private void fmMain_Load(object sender, EventArgs e) {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].HeaderText = "画像";


        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202103DataSet);

        }


        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            
            if (carReportDataGridView.CurrentRow == null) {
                return;
            }
            try {

                //取得したデータ項目を各コントロールへ設定
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;      //日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();     //記録者
                //メーカー(文字列 → 列挙型)
                if (Enum.IsDefined(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value)) {

                    setMakerRadioButton(
                            (CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),
                                    carReportDataGridView.CurrentRow.Cells[3].Value.ToString())
                            );
                }
                else {
                    setMakerRadioButton(CarReport.MakerGroup.その他);
                }
                
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();    //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();     //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);    //画像
            }
            catch (Exception) {
                setMakerRadioButton(CarReport.MakerGroup.その他);
                pbPicture.Image = null;
            }


        }// バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {
        [DisplayName("日付")]
        public DateTime Date { get; set; }  //日付
        [DisplayName("記録者")]
        public string Author { get; set; }  //記録者
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }   //メーカー
        [DisplayName("車名")]
        public string CarName { get; set; } //車名
        [DisplayName("レポート")]
        public string Report { get; set; }  //レポート
        public Image Picture { get; set; }  //写真

        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }

        public void UpDate(DateTime date, 
                        string author, 
                        MakerGroup maker, 
                        string carName, 
                        string report, 
                        Image picture) {
            this.Date = date;
            this.Author = author;
            this.Maker = maker;
            this.CarName = carName;
            this.Report = report;
            this.Picture = picture;
        }
        public CarReport() {

        }
    }

    
}

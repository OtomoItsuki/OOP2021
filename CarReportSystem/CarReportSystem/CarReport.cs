using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        public DateTime Date { get; set; }  //日付
        public string Author { get; set; }  //記録者
        public MakerGroup Maker { get; set; }   //メーカー
        public string CarName { get; set; } //車名
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

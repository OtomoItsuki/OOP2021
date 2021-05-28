using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        private string Title;
        private string ArtistName;
        private int Length;

        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }
        public string printSong() {
            string remainder;
            if (Length % 60 != 0) {
                remainder = Length % 60 + "";
            }
            else {
                remainder = "00";
            }
            String songInfo = "題名：" + Title + ",作者：" + ArtistName + ",演奏時間：" + Length / 60 + ":" + remainder;
            return songInfo;
        }
        
    }
}

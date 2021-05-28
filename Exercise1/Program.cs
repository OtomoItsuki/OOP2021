using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[3];
            songs[0] = new Song("Rythm", "Bird", 300);
            songs[1] = new Song("Dance", "Monkey", 192);
            songs[2] = new Song("Visual", "Dog", 270);
        }
    }
}

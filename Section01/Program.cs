using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var sc = new SampleCode();

            Console.WriteLine(sc.Count(5));
        }
    }

    class SampleCode {
        public int Count(int num) {
            var numbers = new[] { 5, 2, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;
            foreach (var n in numbers) {
                if (n == num) {
                    count++;
                }
            }
            return count;
        }
    }
}

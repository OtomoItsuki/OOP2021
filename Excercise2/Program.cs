using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var ymCollections = new YearMonth[] {
                new YearMonth(2000,12),
                new YearMonth(1999,12),
                new YearMonth(2000,1),
                new YearMonth(1999,1),
                new YearMonth(2101,1),
            };
            Exercise2_2(ymCollections);
            Console.WriteLine("-----");

            Exercise2_4(ymCollections);
            Console.WriteLine("-----");

        }

        private static void Exercise2_4(YearMonth[] ymCollections) {
            var find = FindFirst21C(ymCollections);
        }

        private static void Exercise2_2(YearMonth[] ymCollections) {
            foreach (var yearMonth in ymCollections) {
                Console.WriteLine(yearMonth);
            }
        }

        static YearMonth FindFirst21C(YearMonth[] ymCollections) {
            foreach (var yearMonth in ymCollections) {
                if (yearMonth.Is21Century == true) {
                    return yearMonth;
                }
            }
            return null;
        }
    }
}

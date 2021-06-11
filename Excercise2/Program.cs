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

            Exercise2_5(ymCollections);

        }
        private static void Exercise2_2(YearMonth[] ymCollections) {
            foreach (var yearMonth in ymCollections) {
                Console.WriteLine(yearMonth);
            }
        }
        static YearMonth FindFirst21C(YearMonth[] ymCollections) {
            foreach (var yearMonth in ymCollections) {
                if (yearMonth.Is21Century) {
                    return yearMonth;
                }
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollections) {
            var yearMonth = FindFirst21C(ymCollections);
            var s = yearMonth != null ? "21世紀のデータの年：" +yearMonth.Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }
        
        private static void Exercise2_5(YearMonth[] ymCollections) {
            var array = ymCollections.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var yearMonth in array) {
                Console.WriteLine(yearMonth);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region テスト用ドライバ
            Exercise1_1(numbers);
            Console.WriteLine("----------");

            Exercise1_2(numbers);
            Console.WriteLine("----------");

            Exercise1_3(numbers);
            Console.WriteLine("----------");

            Exercise1_4(numbers);
            Console.WriteLine("----------");

            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine("最大:"+ numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            Console.WriteLine("最後から２つの要素:");
            foreach (var item in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            Console.WriteLine("数値を文字列に変換して表示");
            numbers.Select(n => n.ToString()).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise1_4(int[] numbers) {
            Console.WriteLine("小さい順に3つ表示");
            foreach (var n in numbers.OrderBy(n => n).Take(3)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine("重複を排除し、10より大きい値の数を表示");
            Console.WriteLine(numbers.Distinct().Count(n => 10 < n) + "個");
        }
    }
}

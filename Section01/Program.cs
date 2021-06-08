using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);


            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine();

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine();

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine();

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine();


            Exercise3_1(names);
            Console.WriteLine();


            Exercise3_2();

        }


        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exist)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n/2));
        }

        private static void Exercise1_3(List<int> numbers) {
            //var nums = numbers.Where(n => 50 <= n);

            numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);

        }

        private static void Exercise1_4(List<int> numbers) {
            var list = numbers.Select(n => n * 2).ToList();
            foreach (var num in list) {
                Console.WriteLine(num);
            }
            
        }
        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            var line = Console.ReadLine();
            Console.WriteLine(names.FindIndex(s => s == line));
        }

        private static void Exercise2_2(List<string> names) {
            var contains = names.Count(s => s.Contains('o'));
            Console.WriteLine(contains);
        }

        private static void Exercise2_3(List<string> names) {
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
                foreach(var length in selected) {
                Console.WriteLine(length);
                }
            }
        private static void Exercise3_1(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }

            Console.WriteLine(count);
        }
        private static void Exercise3_2() {
            int num = 10;
            string[] words = new string[num];
            Console.WriteLine("文字列を10個入力");

            for (int i = 0; i < num; i++) {
                Console.WriteLine("文字列{0}:",i+1);
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("処理を選択");
            Console.WriteLine("1 ,小文字のカウント");
            Console.WriteLine("2 ,大文字のカウント");
            Console.WriteLine("3 ,数字のカウント");

            int selectN = int.Parse(Console.ReadLine());
            int count = 0;

            switch (selectN) {
                case 1:
                    foreach (var name in words) {
                        count += name.Count(c => char.IsLower(c));
                    }
                    Console.Write("小文字は");
                    break;
                case 2:
                    foreach (var name in words) {
                        count += name.Count(c => char.IsUpper(c));
                    }
                    Console.Write("大文字は");
                    break;
                case 3:
                    foreach (var name in words) {
                        count += name.Count(c => char.IsDigit(c));
                    }
                    Console.Write("数字は");
                    break;
                default:
                    break;
            }
            Console.WriteLine(count + "個");
        }
    }
}

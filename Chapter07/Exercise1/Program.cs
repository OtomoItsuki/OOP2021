using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            string text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);

        }

        

        private static void Exercise1_1(string text) {
            //キーがA～Zまでのアルファベットでカウント用配列を作成
            var dict = new Dictionary<char, int>();

            //アルファベットの数を数える
            foreach (var c in text.ToLower()) {
                if ('a' <= c && c <= 'z') {
                    if (dict.ContainsKey(c)) {
                        dict[c]++;
                    }
                    else {
                        dict[c] = 1;
                    }
                }
            }

            Console.WriteLine(text.Length);
            //AからZまで順に数えた数を出力する
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine($"'{item.Key}': = {item.Value}");
            }
        }
        private static void Exercise1_2(string text) {
            //キーがA～Zまでのアルファベットでカウント用配列を作成
            var dict = new SortedDictionary<char, int>();

            //アルファベットの数を数える
            foreach (var c in text) {
                if ('a' <= c && c <= 'z') {
                    if (dict.ContainsKey(c)) {
                        dict[c]++;
                    }
                    else {
                        dict[c] = 1;
                    }
                }
            }

            Console.WriteLine(text.Length);
            //AからZまで順に数えた数を出力する
            foreach (var item in dict) {
                Console.WriteLine($"'{item.Key}': = {item.Value}");
            }
        }
    }
}

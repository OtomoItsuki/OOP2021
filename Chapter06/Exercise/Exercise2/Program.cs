using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            #region テスト用ドライバ
            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
            #endregion 
        }

        private static void Exercise2_1(List<Book> books) {
            string findTitle = "ワンダフル・C#ライフ";

            Console.WriteLine($"タイトルが{findTitle}の本の価格とページ数");
            var book = books.FirstOrDefault(x => x.Title == findTitle);
            if (book != null) {
                Console.WriteLine($"価格:{book.Price} ページ数:{book.Pages}");
            }
        }

        private static void Exercise2_2(List<Book> books) {
            string findTitle = "C#";

            Console.WriteLine($"タイトルに「{findTitle}」が含まれる書籍の冊数");
            Console.WriteLine(books.Count(x => x.Title.Contains(findTitle))+ " 冊");
        }

        private static void Exercise2_3(List<Book> books) {
            string findTitle = "C#";

            Console.WriteLine($"タイトルに「{findTitle}」が含まれる書籍の平均ページ数");
            var pagesAverage = books.Where(x => x.Title.Contains(findTitle)).Average(b => b.Pages);
            Console.WriteLine(pagesAverage + "ページ");
        }

        private static void Exercise2_4(List<Book> books) {
            int findPrice = 4000;

            Console.WriteLine($"価格が{findPrice}円以上の最初に見つかる書籍のタイトル");
            var firstBook = books.FirstOrDefault(x => findPrice <= x.Price);
            if (firstBook != null) {
                Console.WriteLine(firstBook.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            int findPrice = 4000;

            Console.WriteLine($"価格が{findPrice}円未満の本の中で最大のページ数");
            var MaxPages4000 = books.Where(x => x.Price < findPrice).Max(x => x.Pages);
            Console.WriteLine(MaxPages4000);
        }

        private static void Exercise2_6(List<Book> books) {
            Console.WriteLine("ページ数が400ページ以上の書籍を価格の高い順に表示");
            var pagesOver400priceDESC = books.Where(x => 400 <= x.Pages).OrderByDescending(x => x.Price);
            foreach (var item in pagesOver400priceDESC) {
                Console.WriteLine($"{item.Title} {item.Price}円");
            }
        }

        private static void Exercise2_7(List<Book> books) {
            Console.WriteLine("タイトルにC#が含まれていてかつ500ページ以下の本のタイトル");
            foreach (var item in books.Where(x => x.Title.Contains("C#") && x.Pages <= 500).Select(x => x.Title)) {
                Console.WriteLine(item);

            }
        }
    }
}

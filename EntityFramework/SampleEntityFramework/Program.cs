using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class Program
    {
        //エントリーポイント
        static void Main(string[] args)
        {
            //using (var db = new BooksDbContext()) {
            //    db.Database.Log = sql => { Debug.Write(sql); };
            //    var count = db.Books.Count();
            //    Console.WriteLine(count);
            //}
            //データの追加
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            DeleteBook();
            //using (var db = new BooksDbContext()) {
            //    var books = db.Books.OrderBy(b => b.PublishedYear).ThenBy(b => b.Author.Name);
            //    foreach (var book in books) {
            //        Console.WriteLine($"{book.Title}{book.PublishedYear}{book.Author.Name}");
            //    }
            //}
            //Console.WriteLine("--------");
            //Exercise13_1_1();
            Console.WriteLine("--------");
            Console.WriteLine("問題13＿2");
            Console.WriteLine("--------");
            Exercise13_1_2();
            Console.WriteLine("--------");
            Console.WriteLine("問題13＿3");
            Console.WriteLine("--------");
            Exercise13_1_3();
            Console.WriteLine("--------");
            Console.WriteLine("問題13＿4");
            Console.WriteLine("--------");
            Exercise13_1_4();
            Console.WriteLine("--------");
            Console.WriteLine("問題13＿5");
            Console.WriteLine("--------");
            Exercise13_1_5();
            Console.WriteLine("--------");

            InsertByConsole();

        }

        private static void InsertByConsole()
        {
            Console.WriteLine("{0}本の追加");
            Console.WriteLine("{1}作者の追加");
            switch (int.Parse(Console.ReadLine())) {
                case 0:
                    InsertBookConsole();
                    break;
                case 1:
                    InsertAuthorConsole();
                    break;
                default:
                    Console.WriteLine("終了します");
                    break;
            }

        }

        private static void InsertAuthorConsole()
        {
            
        }

        private static void InsertBookConsole()
        {
            

            using (var db = new BooksDbContext()) {

                Console.WriteLine("本の作者を入力してください");
                string authorName = Console.ReadLine();
                var author = db.Authors.SingleOrDefault(a => a.Name == authorName);
                if (author is null) {
                    Console.WriteLine("作者が存在しません");
                    Console.WriteLine("作者を作成してください");
                    InsertAuthorConsole();
                    author = db.Authors.Single(a => a.Name == authorName);
                }
                
                Console.WriteLine("本のタイトルを入力してください");
                string title = Console.ReadLine();
                 if(db.Authors.Any(x => x.Books.Any(y => y.Title == title))) {
                    Console.WriteLine("同じ作者の同じタイトルが存在します");
                    Console.WriteLine("追加処理を終了します");
                    return;
                }
                Console.WriteLine("本の発行年を入力してください");
                int? publishedYear = int.Parse(Console.ReadLine());



                var book = new Book {
                    Title = title,
                    PublishedYear = publishedYear,
                    Author = author
                };
                //db.Books.Add(book);

                //db.SaveChanges();
            }
        }

        private static void Exercise13_1_5()
        {
            using (var db = new BooksDbContext()) {
                foreach (var author in db.Authors.OrderBy(x=> x.Birthday)) {
                    Console.WriteLine($"{author.Name} {author.Birthday.ToString("yyyy/MM/dd")}");

                    foreach (var book in author.Books) {
                        Console.WriteLine($"--{book.Title} {book.PublishedYear}");
                    }
                    Console.WriteLine("");
                }
            }
        }

        private static void Exercise13_1_4()
        {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(x => x.PublishedYear).Take(3);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise13_1_3()
        {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(x => x.Title.Length == db.Books.Max(y => y.Title.Length));

                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
                
            }
        }

        private static void Exercise13_1_2()
        {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise13_1_1()
        {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(x => x.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book2);
                var book3 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4
                };
                db.Books.Add(book4);

                db.SaveChanges();
            }
        }

        private static void DeleteBook()
        {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(X => X.Id == 9);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        private static void UpdateBooks()
        {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(b => b.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }
        // List 13-5
        static void InsertBooks()
        {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }
        }

        //List13-7
        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        // List 13-8
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();//F5で実行時、一時停止させる
        }
        // List 13-9
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();


            }
        }

        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Console.WriteLine("-11.1.1-----");
            Exercise1_1(file);

            Console.WriteLine("-11.1.2-----");
            Exercise1_2(file);

            Console.WriteLine("-11.1.3-----");
            Exercise1_3(file);

            Console.WriteLine("-11.1.4-----");
            Exercise1_4(file);

            Console.WriteLine("------------");
        }

        //11.1.1
        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);

            var xelements = xdoc.Root.Elements();
            foreach (var xballsport in xelements) {
                XElement xname = xballsport.Element("name");
                XElement xteammember = xballsport.Element("teammembers");
                Console.WriteLine("競技名：{0} メンバー数：{1}人", xname.Value, xteammember.Value);
            }
        }

        //11.1.2
        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);

            var ballsports = xdoc.Root.Elements().Select(x => new {
                        FirstPlayed = (int)x.Element("firstplayed"),
                        KanjiName = (string)x.Element("name").Attribute("kanji"),
            
            }).OrderByDescending(x => x.FirstPlayed);

            foreach (var ballsport in ballsports) {
                Console.WriteLine("最初にプレーされた年：{0}：漢字の競技名：{1}", ballsport.FirstPlayed, ballsport.KanjiName);
            }

        }

        //11.1.3
        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);

            var ballsport = xdoc.Root.Elements().Select(x => new {
                    TeamMembers = (int)x.Element("teammembers"),
                    Name = (string)x.Element("name")

            }).OrderByDescending(x => x.TeamMembers).First();
            
            Console.WriteLine("メンバー数：{0}人　競技名：{1}", ballsport.TeamMembers, ballsport.Name);


        }
        private static void Exercise1_4(string file) {
            var newFile = "sports.xml";
            
            var element = new XElement("ballsport",
                             new XElement("name", "サッカー", new XAttribute("kanij", "蹴球")),
                             new XElement("teammembers", 11),
                             new XElement("firstplayed", 1863)
                          );
            var xdoc = XDocument.Load("Sample.xml");

            xdoc.Root.Add(element);
            xdoc.Save(newFile);
        }

    }
}

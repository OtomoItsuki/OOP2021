using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var xdoc = XDocument.Load("11_2.xml");

            var pairs = xdoc.Root.Elements().Select(x => new {
                Key = x.Name.LocalName,
                Value = x.Value
            });

            var query = pairs.Select(x => new XElement("word",
                                            new XAttribute("kanji", x.Key),
                                            new XAttribute("yomi", x.Value)));

            var root = new XElement("difficultkanji", pairs);

            root.Save("difficultkanji.xml");

            Console.WriteLine();
        }
    }
}

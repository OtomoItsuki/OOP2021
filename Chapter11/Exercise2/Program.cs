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

            var dkanji = xdoc.Root.Elements();

            var word = new XElement(xdoc.Root.Name);

            var root = new XElement(xdoc.Root.Name, word);

            Console.WriteLine();
        }
    }
}

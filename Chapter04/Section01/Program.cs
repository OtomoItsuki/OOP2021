using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            //var person = new Person {
            //    Name = "新井遥奈",
            //    Birthday = new DateTime(1995, 11, 23),
            //    PhoneNumber = "123-3456-7890",
            //};

            //var list = new List<int> { 10, 20, 30, 40, };
            //var key = 30;
            //var num = list.Contains(key) ? 1 : 0;
            //Console.WriteLine(num);

            string code = "12345";
            //null合体演算子
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);
        }
        //スタブ
        private static object DefaultMessage() {
            return "Default Message";
        }
        private static object GetMessage(object code) {
            return code;
        }
    }
}

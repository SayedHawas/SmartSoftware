using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo
{
    class Program
    {
        //Welcome in github
        static void Main(string[] args)
        {
            pattenMatching();

            checkTypes("Welcome in C# 7 Revision ....");
            checkTypes(111);
            checkTypes(140);
            checkTypes(DateTime.Now);
            Console.ReadLine();
        }
        public static void pattenMatching()
        {
            dynamic text = "Welcome in C# 7 ...";
            text = 11;
            var s = text is string x ? x : "No text here ....";
            Console.WriteLine(s);
            Console.WriteLine(text);
        }

        public static void checkTypes(dynamic x)
        {
            switch (x)
            {
                case string newstring:
                    Console.WriteLine($"{newstring} is string and length is {newstring.Length}");
                    break;
                case int i when i % 2 == 0:
                    Console.WriteLine($"{x} is Number and Even ..");
                    break;
                case int i when i % 2 != 0:
                    Console.WriteLine($"{x} is Number and Odd ..");
                    break;
                default:
                    Console.WriteLine($"{x} is something else ...");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefReturnsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;

            Console.WriteLine($"X = {x} & Y = {y}");
            Console.WriteLine(Max(ref x, ref y));

            Console.WriteLine(Max(ref x, ref y)=30);
            Console.WriteLine($"X = {x} & Y = {y}");

            Console.WriteLine(Max(ref x, ref y) = 50);
            Console.WriteLine($"X = {x} & Y = {y}");


            Console.WriteLine(Max(ref x, ref y));
            Console.WriteLine($"X = {x} & Y = {y}");

            
            var array = new[] { 1, 2, 3, 4, 5 };

            ref int n = ref GetItem(array, 1);
            Console.WriteLine(n);
            n = 22;
            Console.WriteLine(array[1]);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static ref int GetItem(int[] array, int v)
        {
            return ref array[v];
        }

        //function with ref return 
        public static ref int Max(ref int firstNumber, ref int SecondNumber)
        {
            if (firstNumber > SecondNumber)
                return ref firstNumber;
            else
                return ref SecondNumber;
        }
    }
}

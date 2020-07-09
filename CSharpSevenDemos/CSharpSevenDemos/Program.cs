using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryLiteralsAndDigitsSeparators
            BinaryLiteralAndDigitsSeparator();
            Console.ReadLine();
        }

        public static void BinaryLiteralAndDigitsSeparator()
        {
            int binary = 0b1001_1010_1001_0100;
            Console.WriteLine(binary);

            int hex = 0x1c_a0_41_fe;
            Console.WriteLine(hex);

            var numbers = new[] { 0b0_0000000, 0b0_0000001, 0b0_0000010, 0b0_0000011 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            } 
            
                // Without Using digit separators 
            long x = 100000022200000202;
            long z = 10000000020;

            Console.WriteLine("X: {0}", x); 
            Console.WriteLine("Z: {0}", z);

            // Using digit separators 
            long num1 = 1_00_10_00_00_00;
            var num2 = 0b_010_000_000_000_000_000_000_000_000;

            Console.WriteLine("Num1: {0}", num1);
            Console.WriteLine("Num2: {0}", num2);


            // Integer representation.
            Console.WriteLine(24601);
            Console.WriteLine(24_601);

            // Hexadecimal representation.
            Console.WriteLine(0x6019);
            Console.WriteLine(0x60_19);

            // Binary representation.
            Console.WriteLine(0b110000000011001);
            Console.WriteLine(0b110_0000_0001_1001);
        }
    }
}

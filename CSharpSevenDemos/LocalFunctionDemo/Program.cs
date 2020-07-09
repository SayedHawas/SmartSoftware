using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            localFunction();
            Console.ReadLine();
        }

        public static void localFunction()
        {
            //Local Function 
             int fun_return_x (int x) { return x; };
            //Lambda Expression 
            Func<int, int> fun_Lambda_return = (x) => x;

            Console.WriteLine($"Local Function {fun_return_x(10)}");
            Console.WriteLine($"Lambda Expression Function {fun_Lambda_return(20)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    salary();
                }
                catch (Exception exOuter)
                {
                    Console.WriteLine(exOuter.Message);
                } 
            } while (true);
            Console.ReadLine();
        }

        public static void salary()
        {
            decimal _salary, _tax, _NetSalary;
            try
            {
                Console.Write("Enter Your Salary:");
                _salary = Convert.ToDecimal(Console.ReadLine());
                if (_salary <= 0 || _salary > 50000)
                    throw new Exception("Salary Must between 1 and 50000");

                Console.Write("Enter Your tax:");
                _tax = Convert.ToDecimal(Console.ReadLine());
                if (_tax == 1)
                    throw new Exception("tax Not Equal 100 %");

                _NetSalary = _salary - _salary * _tax;

                Console.WriteLine($" Your Net Salary is {_NetSalary}");
            } 
            catch (Exception exInner) when (exInner.Message.Equals("Salary Must between 1 and 50000"))
            {
                Console.WriteLine(exInner.Message);
                Console.WriteLine("Error in Salary ...");
            }
            catch (Exception exInner) when (exInner.Message.Equals("tax Not Equal 100 %"))
            {
                Console.WriteLine(exInner.Message);
                Console.WriteLine("Error in tax ...");
            }
           catch (Exception exInner)
            {
                throw new Exception("Salary Or tax Format is Not Match", exInner.InnerException);
            }
           

        }
    }
}

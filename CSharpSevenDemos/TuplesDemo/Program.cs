using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TuplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old Style Tuple
            var tuple = new Tuple<int, int>(1, 2);
            Console.WriteLine(tuple.Item1);

            var data = new Tuple<int, int>(1, 10);
            var course = data.Item1;
            var topics = data.Item2;
            Console.WriteLine($"Course No {course} Number of topices {topics}");


            // New Style C# 7
            var Newdata = (project:1, developers : 10);
            Console.WriteLine($"Project  No {Newdata.project} count of Developers {Newdata.developers}");


            //return tuple
            (int tax, int Salary) ReturnTupleFun() => (tax: 100, Salary: 2000);
            Console.WriteLine($"Salary is {ReturnTupleFun().Salary} , tax is {ReturnTupleFun().tax}");


            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();

            (int, int) data2 = FindMinMax(numbers);
            Console.WriteLine($"{data2.Item1} is min and {data2.Item2} is max from {String.Join(",", numbers)}");

            // New Style C#7
            Console.WriteLine($"{FindMinMax2(numbers).Minimum} is min and {FindMinMax2(numbers).Maximum} is max from {String.Join(",", numbers)}");

            Console.ReadLine();
        }


        internal static(int, int) FindMinMax(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            return (minimum, maximum);
        }


        internal static (int Minimum, int Maximum) FindMinMax2(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            return (minimum, maximum);
        }
    }
}

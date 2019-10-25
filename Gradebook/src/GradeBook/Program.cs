using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var sum = 0.0;
            //var numbers = new[] {1.5, 2.5, 3.5};
            var grades = new List<double>() {1.522, 2.544, 3.555};
            grades.Add(4.666);
            foreach (var number in grades) {
                sum += number;
            }
            i = grades.Count;
            //System.Console.WriteLine(i);
            var avg = sum/i;
            //System.Console.WriteLine(sum);
            System.Console.WriteLine($"The average Grade is {avg:N1}");
            //var sum2 = 0.0;

            /*for (var i = 0; i<numbers.Length; i++){
                sum = sum + numbers[i];
                System.Console.WriteLine(i);
            }*/
            /*foreach (var number in numbers) {
                sum2 += number;
            }
            Console.WriteLine(sum2);*/

            if (args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");
            }else {
                Console.WriteLine("Hello");
            }

            //var result = Average(x, y);
            //Console.WriteLine(result);
        }
        static double Average(double x, double y)
        {
            return ((x+y)/2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, num3;
            num1 = 28;
            num2 = 234.3;
            num3 = 345.444;
            double result = Add(5, 17.5);
            Console.WriteLine($"5 + 17.5 = {result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");

            double[] nums = { num1, num2, num3 };
            nums = new double[3];
            nums[0] = num1;
            nums[1] = num2;
            nums[2] = num3;
            nums[3] 

            Console.ReadKey();
        }

        static double Add(double val1, double val2)
        {

            double sum = val1 + val2;

            return sum;
        }
    }
}

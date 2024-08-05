using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");

            int var1;
            while (true)
            {
                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("You can only enter int number");
                }
            }

            Console.WriteLine("Enter second number");

            int var2;
            while (true)
            {
                try
                {
                    var2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("You can only enter int number");
                }
            }

            int sum = Sum(var1, var2);
            Console.WriteLine("Sum is: " + sum);
            Console.ReadLine();
        }
        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}

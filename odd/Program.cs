using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("please enter a number and i will tell you if its odd or even");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }
            Console.ReadLine();
        }
    }
}

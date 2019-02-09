using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        // 7! = 7 * 6 * 5 * 4 * 3 * 2 * 1
        // 5! = 5 * 4 * 3 * 2 * 1 = 120
        // 5! = 5 * 4!

        // f(x) = x * f(x-1)


        //static int Factorial(int input)
        //{
        //    int output = 1;
        //    for (int i = input; i != 0; i--)
        //    {
        //        output *= i;
        //    }
        //    return output;
        //}

        static int Factorial(int input)
        {
            //escape case
            if(input <= 1)
            {
                return 1;
            }


            return input * Factorial(input - 1);
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number to find out its factorial");
            int userInput = int.Parse(Console.ReadLine());
            int answer = Factorial(userInput);
            Console.WriteLine($"{answer}");
            Console.ReadKey();
        }
    }
}

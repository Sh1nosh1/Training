using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Training
{
    internal class Program
    {
        /* static int Input1(string numb)
         {
             Write($"Enter {numb} number: ");
             int x = Convert.ToInt32(ReadLine());
             return x;
         }
         static void Main(string[] args)
         {
             int sum = Input1("first") - Input1("second");
             WriteLine($"Sum of numbers: {sum}");
             ReadKey();
         }*/

        /*static int Input2(string numb)
        {
            Write($"Enter {numb} side: ");
            int side = Convert.ToInt32(ReadLine());
            return side;
        }
        static void Main(string[] args)
        {
            int S = Input2("first") * Input2("second");
            WriteLine($"The area of rectangle: {S}");
            ReadKey();
        }*/

        /*static int Input3()
        {
            Write("Enter a number: ");
            int x = Convert.ToInt32(ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            if (Input3() % 2 == 0) { WriteLine($"even number"); }
            else { WriteLine($"odd number"); }
            WriteLine();
            int x = Input3();
            if (x % 2 == 0) { Write($"{x} - even number"); }
            else { Write($"{x} - odd number"); }
            ReadKey();
        }*/

        static double Input4(string number)
        {
            Write($"Enter {number} triangle side: ");
            double x = Convert.ToDouble(ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            double P = Input4("first") + Input4("second") + Input4("third");
            WriteLine($"Perimeter of a triangle: {P:f0}");
            ReadKey();
        }
    }
}

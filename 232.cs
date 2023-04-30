using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
                int i = 6; // номер варіанту
                double a = 0;
                double b = i;

                Console.WriteLine("x\ty");
                for (double x = a; x <= b; x += 0.1 * i)
                {
                    double y = (9.0 / 2) * Math.Cos(2 * x) - Math.Abs(Math.Sin(x / 1.1));
                    Console.WriteLine(x + "\t" + y);
                }

                double sum = (9.0 / 2) * Math.Cos(2 * a) - Math.Abs(Math.Sin(a / 1.1))
                             + (9.0 / 2) * Math.Cos(2 * b) - Math.Abs(Math.Sin(b / 1.1));
                int count = (int)((b - a) / (0.1 * i)) + 1;

                Console.WriteLine("Sum of first and last terms: " + sum);
                Console.WriteLine("Number of values: " + count);
                Console.ReadLine();
            }
        }

    }


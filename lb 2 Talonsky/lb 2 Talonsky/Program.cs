using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lb_1_Talonsky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Задание 2");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            try
            {
                Console.WriteLine("Введите длину ребра куба = ");
                double x = Double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    double y;
                    double z;
                    y = x*x*x;
                    z = x*x*6+0;
                    Console.WriteLine("Обьём куба = " + y);
                    Console.WriteLine("Площадь его поверхности = " + z);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некорректные данные.");
                Console.ReadLine();
            }



        }
    }
}

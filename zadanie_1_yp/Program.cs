using System;

namespace zadanie_1_yp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите Х: ");
                double x = 0;
                
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    do
                    {
                        Console.WriteLine("неправильный ввод");
                        Console.Write("Введите Х еще раз: ");
                    } while (!double.TryParse(Console.ReadLine(), out x));
                }
                Console.WriteLine("Введите Y: ");
                double y = 0;
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    do
                    {
                        Console.WriteLine("неправильный ввод");
                        Console.Write("Введите Y еще раз: ");
                    } while (!double.TryParse(Console.ReadLine(), out y));
                }
                double r1 = 15;
                double r2 = 25;

                
                

                if (x * x + y * y == r1 * r1)
                {
                    Console.WriteLine("На границе");
                }
                else if (x * x + y * y < r1 * r1)
                {
                    Console.WriteLine("Внутри");
                }
                else if (x * x + y * y == r2 * r2)
                {
                    Console.WriteLine("На границе");
                }
                else if (x * x + y * y < r2 * r2)
                {
                    Console.WriteLine("Вне");
                }
                else Console.WriteLine("Внутри");
            }
        }

    }
}

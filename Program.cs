using System;

namespace ClassesAndObjectsTask2
{
    class Program
    {
        static void Main()
        {
            Triangle firstTriangle = new Triangle(7, 3, 6);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Параметры треугольника");
            Console.ResetColor();
            Console.WriteLine(firstTriangle);
            Console.WriteLine($"Периметр треугольника: P = {firstTriangle.CalcPerimeter()} см");
            Console.WriteLine($"Площадь треугольника S = {firstTriangle.CalcArea():f2} см");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nДемонстрация работы индексатора");
            Console.ResetColor();
            Console.WriteLine(firstTriangle[0]);
            Console.WriteLine(firstTriangle[1]);
            Console.WriteLine(firstTriangle[2]);
            Console.WriteLine(firstTriangle[4]);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nДемонстрация перегрузки операций и констант");
            Console.ResetColor();
            Console.WriteLine(firstTriangle++);
            Console.WriteLine(firstTriangle--);

            if (firstTriangle)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Треугольник с заданными длинами сторон существует");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Треугольник с заданными длинами сторон не существует");
                Console.ResetColor();
            }

            Console.WriteLine(firstTriangle * 9);

            Console.ReadKey();
        }
    }
}

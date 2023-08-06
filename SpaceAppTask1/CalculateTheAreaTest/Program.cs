using System;

namespace CalculateTheAreaTest
{
    class Program
    {
   
        private static int ReadPositiveNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    return number;
                }
                    
                Console.WriteLine("Некорректный ввод, введите натуральное число.");
            }
        }

        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"The Area = {circle.Square()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"The Area = {triangle.Square()}");


            // Проверку на то, является ли треугольник прямоугольным 
            int a = ReadPositiveNumber("Введите a = ");
            int b = ReadPositiveNumber("Введите b = ");
            int c = ReadPositiveNumber("Введите c = ");

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Это не треугольник!");
            }
               
            else if (a == b && b == c)
            {
                Console.WriteLine("Это равносторонний треугольник!");
            }
                
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Это равнобедренный треугольник!");
            }

            else
            {
                Console.WriteLine("Это треугольник.");
            }
                

            Console.ReadKey();
        }
    }
}

using System;

namespace TasksOfTheNTOSchoolOlympiad
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Задачи первого этапа. Информатика
                Задача I.1.1.1. Расчет скидки 
                Темы: задачи для начинающих, простая математика.
            Одна продуктовая сеть в рамках акции выдает скидочные купоны двух видов.
            По первому купону можно получить скидку в 8% от стоимости покупки, но не более
            100 рублей. По второму купону можно получить скидку в 5% от стоимости покупки
            без других ограничений. Предъявлять можно только один купон, разделять покупку
            на части нельзя. Покупатель делает покупку на p рублей. У него есть оба купона.
            Напишите программу, которая вычислит максимальный размер скидки, которую покупатель сможет получить.

            */
            Console.Write("Kolichestvo photographii = ");
            int n = int.Parse(Console.ReadLine());
            int s = Convert.ToInt32(n <= 10) * 0 + Convert.ToInt32(10 < n && n <= 50) * 1 + Convert.ToInt32(50 < n) * 2;
            switch (s)
            {
                case 0:
                    Console.WriteLine("Skitka: 0 %");
                    break;
                case 1:
                    Console.WriteLine("Skitka: 10 %");
                    break;
                case 2:
                    Console.WriteLine("Skitka: 15 %");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}

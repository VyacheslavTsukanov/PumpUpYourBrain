using System;

namespace LayoutPrototype
{
    class Program
    {

        //private static double freeArea()
        //{
        //    double Summ = totalArea - bedArea;
        //    return Summ;
        //}
        //private static float roomSize(float wid, float len) // Высчитывает площадь
        //{
        //    float sum;
        //    sum = wid * len;
        //    return sum;

        //}
        static void Main(string[] args)
        {
            // Высчитывает объщую площадь
            furniture square = new furniture();
            double squareWid = square.wid;
            double squareLen = square.len;

            square.wid = 3.60;
            square.len = 5.70;
            Console.WriteLine("Объщая площадь: " + square.Print());

            square.wid = 2.10;
            square.len = 0.90;
            Console.WriteLine("Площадь дивана: " + square.Print());

            square.wid = 2.00;
            square.len = 1.40;
            Console.WriteLine("Площадь кровати: " + square.Print());

            square.wid = 1;
            square.len = 3;
            Console.WriteLine("Площадь шкафа: " + square.Print());



            // totalArea, bedArea, sofaArea, cabinetArea
            //float wid, len;

            //Console.WriteLine("Введите размер комнаты: ");
            //Console.Write("Ширина: ");
            //wid = float.Parse(Console.ReadLine());
            //Console.Write("Длина: ");
            //len = float.Parse(Console.ReadLine());

            //Console.WriteLine("Площадь комнаты: " + roomSize(wid, len) + "m");


            //Console.WriteLine("\nВысчитываем площадь кровати: ");
            //Console.Write("Ширина: ");
            //wid = float.Parse(Console.ReadLine());
            //Console.Write("Длина: ");
            //len = float.Parse(Console.ReadLine());

            //Console.WriteLine("Площадь кровати: " + roomSize(wid, len) + "m");
            //Console.WriteLine();


            //Console.WriteLine("\nВысчитываем площадь дивана: ");
            //Console.Write("Ширина: ");
            //wid = float.Parse(Console.ReadLine());
            //Console.Write("Длина: ");
            //len = float.Parse(Console.ReadLine());
            //Console.WriteLine("Площадь дивана: " + roomSize(wid, len) + "m");

            //Console.WriteLine("\nВысчитываем площадь шкафа: ");
            //Console.Write("Ширина: ");
            //wid = float.Parse(Console.ReadLine());
            //Console.Write("Длина: ");
            //len = float.Parse(Console.ReadLine());
            //Console.WriteLine("Площадь шкафа: " + roomSize(wid, len) + "m");

            //Console.WriteLine("Площадь свободного места: " + freeArea());


            Console.ReadLine();
        }

       
    }
}


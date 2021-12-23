using System;

namespace _2._2_15v
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.2. Начальный уровень
            try
            {
                Console.WriteLine("Введите A(x0;y0):");
                double x0 = double.Parse(Console.ReadLine());
                double y0 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите B(x1;y1):");
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                if (x0 + y0 < x1 + y1) Console.WriteLine("Точка A(x0;y0) наименее удалена от начала кординат");
                else Console.WriteLine("Точка B(x1;y1) наименее удалена от начала кординат");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

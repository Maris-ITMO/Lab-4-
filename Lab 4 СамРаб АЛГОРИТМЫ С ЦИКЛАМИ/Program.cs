using System;

namespace Lab_4_СамРаб_АЛГОРИТМЫ_С_ЦИКЛАМИ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (2 * i - 1);
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

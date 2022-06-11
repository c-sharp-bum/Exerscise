using System;

namespace Lesson4
{
    class Program
    {
        static int Sum(int a, int b)
        {

            return a + b;
        }
        static void PrintLine()
        {
            Console.WriteLine("Метод прінтлайн був викликаний");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a,b,c;
              Console.WriteLine("Введіть перше число");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число");
            b = int.Parse(Console.ReadLine());

            c = Sum(a , b);

            Console.WriteLine("Сума чисел = " + c);

            PrintLine();

           
        }
    }
}
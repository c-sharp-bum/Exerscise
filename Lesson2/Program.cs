using System;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double numValueOne, numValueTwo;

            string action;

            while (true)
             {
                Console.Clear();
                try
                {
                    Console.WriteLine("Введіть перше число");

                    numValueOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть друге число");

                    numValueTwo = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Помилка натисніть Enter");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Виберіть операцію : *, /, -, +  ");

                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(numValueOne + numValueTwo);
                        break;

                    case "-":
                        Console.WriteLine(numValueOne - numValueTwo);
                        break;
                    case "*":
                        Console.WriteLine(numValueOne * numValueTwo);
                        break;
                    case "/":
                        
                        break;
                        if (numValueTwo == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(numValueOne / numValueTwo);
                        }

                    default:
                        Console.WriteLine("Не відома операція натисніть Enter");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
using System;
namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, width;

            Random random = new Random();

            Console.WriteLine("Введіть висоту масиву");

            height = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Введіть ширину масиву");

            width = int.Parse(Console.ReadLine());

            int[,] myArray = new int[height, width];

            int[,] myArray2 = new int[height, width];

            int[,] sumMyArray =  new int[height,width] ;

           
            
            //Заповнення першого масиву

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y : " + i + " X : " + j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine();

            //Вивід першого масиву
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + "\t");

                }
                Console.WriteLine();
            }

            //Заповнення другого масиву з Random
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    
                    myArray2[i, j] = random.Next(10) ;
                }

            }
            Console.WriteLine();

            //Вивід другого масиву з Random
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Console.Write(myArray2[i, j] + "\t");

                }
                Console.WriteLine();
            }
            //Різниця першого і другого масиву 
            for (int i = 0; i < sumMyArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumMyArray.GetLength(1); j++)
                {

                    sumMyArray[i, j] = myArray[i, j] - myArray2[i, j];

                    if (sumMyArray[i,j] % 2 == 0)
                    {
                        Console.WriteLine(sumMyArray[i,j] + "*");
                    }
                    else
                    {
                        Console.WriteLine(sumMyArray[i,j] + "\t");
                    }
                }

            }
            Console.WriteLine();


            
            


        }
    }
}
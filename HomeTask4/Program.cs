using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    class Program
    {
        static int GetNumberOfPairs(int[] array, int length)
        {
            int ammountOfPairs = 0;
            for(int i=0; i<length-1; i++)
            {
                if(array[i] %3 == 0 || array[i+1] %3 == 0)
                {
                    ammountOfPairs++;
                }
            }
            return ammountOfPairs;
        }

        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random random = new Random();
            int result;

            Console.WriteLine("Вас приветствует программа продсчета пар элементов, где хотя бы 1 число делится на 3");
            Console.Write("\nВ следующем массиве [ ");
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(-10000, 10001);
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");

            result = GetNumberOfPairs(myArray, arrayLength);

            Console.WriteLine($"Количесто пар: {result}");

            Console.ReadKey();
            
        }
    }

}
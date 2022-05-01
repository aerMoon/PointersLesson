using System;

namespace _6_PointersAndArrays
{
    internal class Program
    {
       static unsafe void Main(string[] args)
        {
            int size = 10; //размер массива
            int* pnt;       // объявление указателя
            int[] numbers = new int[size]; //массив целых чисел размерностью size

            Console.WriteLine("заполнение массива:");

            fixed (int* p = numbers)  //фиксируем указатель
            {
                pnt = p + size - 1;     //запись значения в указатель

                //перебор элементов массива
                for(int i = 0; i < numbers.Length; i++)
                {
                    p[i] = i + 10;  //запись значения в ячейку массива через указатель
                    Console.Write($" {p[i]}");
                }

                //перебор элементов массива с помощью указателя
                while (p <= pnt)
                {
                    (*pnt) *= (*pnt);   // возведение значения элемента массива в квадрат через указатель
                    pnt--;               // переход к следующему элементу через указатель
                }
            }//end fixed

            Console.WriteLine("\nМассив после изменения:");
            for(int i = 0; i < numbers.Length;i++)
            {
                Console.Write($" {numbers[i]}");
            }

        }
    }
}

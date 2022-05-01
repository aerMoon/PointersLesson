/*
 * дополнительное задание:
 * почитать о прямом и обратном порядке и сделать вывод 
 * - какой спосбо хранения данных реализован в данном примере
 * https://it.wikireading.ru/2021
 */
using System;

namespace _9_ArrayOfPointers
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            int z = 300;

            int*[] nums = new int*[3];  //массив указателей на целые числа (int - 4байта)

            //заполнение массива значениями
            nums[0] = &x;
            nums[1] = &y;
            nums[2] = &z;

            Console.WriteLine("массив указателей на целые числа:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"в ячейке по адресу {(uint)nums[i]} хранится значение: {(uint)*nums[i]}");
            }

            char*[] symbols = new char*[3]; //массив указателей на символы (char - 2байта)

            //заполненеи массива символьных указателей
            symbols[0] = (char*)&x;
            symbols[1] = (char*)&y;
            symbols[2] = (char*)&z;

            char s = '*';
            Console.WriteLine("\nмассив указателей на символы:");

            //заполнение значенииями той области памяти, что выделена под переменные:
            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < sizeof(int)/sizeof(char); j++) //заполнение всего возможного диапазона - т.к. в один int помещается два char
                {
                    symbols[i][j] = s; //запись значения в блок памяти
                    s++;
                    Console.WriteLine($"в ячейке по адресу {(uint)symbols[i]} хранится значение: {symbols[i][j]}");
                }
            }

        }
    }
}

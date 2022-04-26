using System;

namespace _3_indexingPoints
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double val;
            int k = 1;
            double* start, end; //указатели на знанчения типа double
            
            start=&val;         //запись значений в указатели
            end=start+1;

            //отображение адресов
            Console.WriteLine($"Адрес start\t {(uint)start}");
            Console.WriteLine($"Адрес end  \t {(uint)end}");

            //разность адресов
            Console.WriteLine($"разность адресов {(uint)end-(uint)start}\n");

            //разность указателей
            Console.WriteLine($"разность double-указателей  \t{end-start}");
            Console.WriteLine($"разность int-указателей     \t{(int*)end-(int*)start}");
            Console.WriteLine($"разность char-указателей    \t{(char*)end-(char*)start}");
            Console.WriteLine($"разность byte-указателей    \t{(byte*)end-(byte*)start}");

            byte* p = (byte*)start; //указатель на значение byte
            char* q = (char*)start; //указатель на значение char
            int* r = (int*)start;   //указатель на значение int

            Console.WriteLine("тип byte:");
            Console.WriteLine("адрес \tзначение");
            while (p<end)
            {
                *p=(byte)k; //запись значения в блок памяти
                Console.WriteLine($"{(uint)p}\t{*p}"); ;
                p++;
                k+=2;
            }

            Console.WriteLine("тип char:");
            Console.WriteLine("адрес \tзначение");
            for (k=0; q+k<end; k++)
            {
                *(q+k)=(char)('A'+2*k);
                Console.WriteLine($"{(uint)(q+k)}\t{*(q+k)}");
            }

            Console.WriteLine("тип int:");
            Console.WriteLine("адрес\tзначение");
            for (k=0; &r[k]<end; k++)
            {
                r[k]=5*(k+1);
                Console.WriteLine($"{(uint)&r[k]}\t{r[k]}");
            }
        }
    }
}

using System;

namespace _8_PointerToPointer
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int a, b;
            int* p;     //указатель на целочисленную переменную
            int** q;    //указатель на указатель целочисленной переменной

            q = &p;
            p = &a;

            **q = 1000; //присваивание переменной значения через указатель на указатель

            Console.WriteLine(a);

            Console.WriteLine($"адрес, хранимый в указателе p:  \t{(uint)p}"); //
            Console.WriteLine($"адрес, хранимый в указателе q:  \t{(uint)q}");
            Console.WriteLine($"значение, хранимое в указателе q:\t{(uint)*q}");
        }
    }
}

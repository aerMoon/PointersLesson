using System;

namespace PointersLesson
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int n;  
            int* p;     //объявление указателя на значение типа int
            p = &n;     //запись в указатель адреса переменной n
            *p = 500;   //запись значения в ячейку через указатель

            Console.WriteLine($"значение переменной n: {n}");
            Console.WriteLine($"значение выражения *p {*p}");
            Console.WriteLine($"адрес переменной {(uint)p}");
            Console.WriteLine("");

            byte* q;    //объявление указателя на значение типа byte
            char* c;    //объявление указателя на значение типа char

            //присваивание укзателей и явное приведение типа
            q = (byte*)p; 
            c = (char*)q;

            n = 65601;

            //проверка значений указателей
            Console.WriteLine($"адрес в указателе p: {(uint)p}");
            Console.WriteLine($"адрес в указателе q: {(uint)q}");
            Console.WriteLine($"адрес в указателе c: {(uint)c}");
            Console.WriteLine("");

            //отображение значения через указатель
            Console.WriteLine($"значение типа int: {*p}");
            Console.WriteLine($"значение типа byte: {*q}");
            Console.WriteLine($"значение типа char: {*c}");
            Console.WriteLine($"значение переменной n: {n}");
            Console.WriteLine();

            //присваивание значения через указатель:
            *c = 'f';
            Console.WriteLine($"значение типа int: {*p}");
            Console.WriteLine($"значение типа byte: {*q}");
            Console.WriteLine($"значение типа char: {*c}");
            Console.WriteLine($"значение переменной n: {n}");
            Console.WriteLine();
        }
    }
}

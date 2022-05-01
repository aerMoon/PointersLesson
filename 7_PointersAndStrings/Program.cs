using System;

namespace _7_PointersAndStrings
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            string text = "я обязательно сдам на экзамен на 4!";
            Console.WriteLine(text);

            fixed (char* p = text) //фиксация указателя на 1 символе строки
            {
                //проход по всем символам строки
                for (int i = 0; p[i]!='\0'; i++) //'\0' - управляющий символ окончания строки
                {
                    if (p[i] == '4') p[i] = '5';
                    Console.Write(p[i]);
                }
            }
        }
    }
}

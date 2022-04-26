using System;

namespace indexingPoints
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double miniarray;
            int m = sizeof(double)/sizeof(byte); //размер byte-массива

            void* pnt;         //указатель неопределенного вида
            pnt=&miniarray;    //запись адреса в указатель

            byte* p;           // указатель на byte-значение
            p=(byte*)pnt;      // значение указателя

            //перебор блоков памяти с помощью указателя
            for (int k = 0; k<m; k++)
            {
                p[k]=(byte)(k+1);           //запись значения в блок памяти
                Console.Write("|"+p[k]);    //вывод значения
            }
            Console.WriteLine("|");

            //новое значение указателя
            p=(byte*)pnt+m-1;

            //перебор блоков памяти с помощью указателя
            for (int k = 0; k<m; k++)
            {
                Console.Write("|"+p[-k]);    //отрацательный индекс
            }
            Console.WriteLine("|");

            
            int n = sizeof(double)/sizeof(char); // размер char массива
            char* q;
            q=(char*)pnt;

            //перебор блоков памяти с помощью указателя
            for (int k = 0; k<n; k++)
            {
                q[k]=(char)('A'+k);         //запись значения в блок памяти
                Console.Write("|"+q[k]);    //вывод значения
            }
            Console.WriteLine("|");

            q=(char*)pnt+n-1;
            for (int k = 0; k<n; k++)
            {
                Console.Write("|"+q[-k]);
            }
            Console.WriteLine("|");
        }
    }
}

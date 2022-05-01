using System;

namespace _4_PointerToStructure
{
    //структура Чек
    struct Check 
    {
        //целочисленные поля
        public int id;  
        public int summ;

        //метод для вывода информации по текущему экземпляру структуры
        public void Show()
        {
            Console.WriteLine($"чек {id}: сумма - {summ}");
        }
    }
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Check check1, check2;   // создание экземпляров структур
            Check* checkPoint;      // создание указателя на структуру

            checkPoint = &check1;   // присваивание указателю начального адреса структуры

            // обращение к полям структуры через указатель
            checkPoint -> id   = 1; 
            checkPoint -> summ = 1000;    
            
            checkPoint -> Show();     // вызов метода структуры через указатель

            checkPoint = &check2;   // новое значение указателя

            // обращение к полям структуры через указатель
            checkPoint->id   = 2;
            checkPoint->summ = 500;

            checkPoint->Show();     // вызов метода структуры через указатель

            Console.WriteLine("\n---второй способ обратиться через указатель---");

            (*checkPoint).summ = 3000;
            (*checkPoint).Show();

        }
    }
}

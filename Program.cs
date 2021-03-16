using System;

namespace StosStrukturalnie
{
    class Program
    {
        static void Main(string[] args)
        {
            var stos1 = new Stos(5);
            var stos2 = new Stos(5);

            stos1.Push(1);
            stos1.Push(2);
            stos1.Push(3);
            stos1.Push(4);
            stos1.Pop();
            stos1.Pop();
            stos1.Display();

            stos2.Push(3);
            stos2.Push(2);
            stos2.Push(4);
            stos2.Pop();
            stos2.Pop();
            stos2.Display();
            stos1.Display();
            Console.WriteLine(stos1.Top());
            Console.WriteLine(stos2.Top());
        }
    }
}

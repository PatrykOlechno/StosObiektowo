using System;

namespace StosStrukturalnie
{
    class Program
    {
        static void Main(string[] args)
        {
            var stos1 = new Stos(5);
            var stos2 = new Stos(5);

            Console.WriteLine(stos1.Full());
            Console.WriteLine(stos1.Empty());
            stos1.Push(1);
            stos1.Push(2);
            Console.WriteLine(stos1.Empty());
            stos1.Push(3);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            Console.WriteLine(stos1.Full());
           
            stos1.Display();

            stos2.Push(3);
            stos2.Push(2);
            stos2.Push(4);
            Console.WriteLine(stos1.Full());
             Console.WriteLine(stos1.Empty());
            stos2.Pop();
            stos2.Pop();
            stos2.Display();
            stos1.Display();
            Console.WriteLine(stos1.Top());
            Console.WriteLine(stos2.Top());
            stos1.Destroy();
            stos1.Display();
            stos1.Push(3);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            stos1.Push(4);
            Console.WriteLine("XD" + stos1.Count);
            stos1.Push(4);
            stos1.Display();
        }
    }
}

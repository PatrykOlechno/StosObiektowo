using System;

namespace StosStrukturalnie
{
    class Program
    {
        static void Main(string[] args)
        {
            int RozmiarStosu = 10;
            var stos1 = new Stos(RozmiarStosu);
            var stos2 = new Stos(RozmiarStosu);

            Console.WriteLine("Podaj 10 liczb: ");
            for (int i = 0; i < RozmiarStosu; i++)
            {
                stos1.Push(Convert.ToInt32(Console.ReadLine()));
            }

            // alternatywa wpisywanie do testow
           /* for(int i = 0; i < RozmiarStosu; i++)
            {
                stos1.Push(i);
            }*/

            Console.WriteLine("Stos 1 przy pomocy stosu 2: ");
            for (int i =0; i < RozmiarStosu; i++)
            { 
                stos2.Push(stos1.Top()); //wstawiamy element z gory stosu 1 do stosu 2
                Console.WriteLine(stos2.Top()); // wypisujemy stos numer 2
                stos1.Count--; // przechodzimy do elementu nizej
            }

            stos1.Count = RozmiarStosu; // na koniec wracamy do poczatkowej wartosci stosu 1
            stos1.Display(); // testowe sprawdzenie czy stos 1 nadal jest rowny stanowi poczatkowemu
        }
    }
}

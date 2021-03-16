using System;
using System.Collections.Generic;
using System.Text;

namespace StosStrukturalnie
{
    class Stos
    {
        public int Count;
        private int[] stack;

        /*Konstruktor zamiast funkcji init*/
        public Stos(int size)
        {
            stack = new int[size];
            Count = 0;
        }

        /*Dodaje element na gore stosu*/
        public void Push(int number)
        {
            if (Count >= stack.Length)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                stack[Count] = number;
                Count++;
            }
            
        }

        /*Usuwa element z gory stosu*/
        public int Pop()
        {
            if(Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Count--;
                return stack[Count];
            }
            
        }

        /*Wyswielta caly stos*/
        public void Display()
        {
            if (Count == 0) {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Console.WriteLine("Stack: ");
                for(int i = Count - 1; i>= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

        /*Zwraca element z gory stosu*/
        public int Top()
        {
            return stack[Count-1];
        }

        /*Zwraca true gdy stos jest pusty*/
        public bool Empty()
        {
            return Count == 0;
        }

        /*Zwraca true gdy stos jest pelny*/
        public bool Full()
        {
            return Count == stack.Length;
        }

        /*Przywraca stos do stanu poczatkowego*/
        public void Destroy()
        {
            //garbage collector zajmie sie obiektem, ale nie nastapi to od razu
            //wiec po prostu zapominamy o poprzednich danych a obiekt zostaje cofniety do stanu poczatkowego
            Count = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StosStrukturalnie
{
    class Stos
    {
        public int Count;
        private int[] stack;

        public Stos(int size)
        {
            stack = new int[size];
            Count = 0;
        }

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

        public void Display()
        {
            if (Count == 0) {
                Console.WriteLine("Stos jest pusty");
                return;
            }
            else
            {
                Console.WriteLine("Co na stosie: ");
                for(int i = Count - 1; i>= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

        public int Top()
        {
            return stack[Count];
        }

    }
}

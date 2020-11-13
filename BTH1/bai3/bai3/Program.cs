using System;

namespace bai3
{
    class stack
    {
        private int top;
        private int[] s;
        
        public stack()
        {
            top = -1;
            s = new int[20];
        }
        public stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        public bool empty()
        {
            if (top==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool full()
        {
            if (top == s.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push(int x)
        {
            if (full())
            {
                Console.WriteLine("Stack da day");
            }
            else
            {
                s[++top] = x;
            }
        }
        public int pop()
        {
            if (empty())
            {
                throw new Exception("Stack rong");
            }
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

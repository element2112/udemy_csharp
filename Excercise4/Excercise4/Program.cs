using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Excercise4
{
    public class Stack
    {
        private readonly ArrayList list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Object cannot be added");
            }

            list.Add(obj);
        }

        public object Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            int n = list.Count - 1;

            var res = list[n];
            list.RemoveAt(n);

            return res;
        }

        public void Clear()
        {
            list.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}

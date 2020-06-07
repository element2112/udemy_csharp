using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Value_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types: stored on stack ex: all primitive types, struct type. 

            // reference types: stored on heap ex: any classes (longer life cycle)

            // Boxing: The process of converting a value type instance to an object reference
            int number = 10;
            object obj = number;

            // or
            object obj2 = 10; // value is boxed by clr and stored in the heap instead of the stack

            // unboxing is the opposite of boxing
            object obj3 = 10;
            int number2 = (int)obj;

            // they have a performance penalty due to creating an extra object

            var list = new ArrayList();
            // all of these are boxed because ArrayLists only takes objects
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today); 

            var num = (int) list[1];

            // generic list prevents boxing because its a list of ints not objects
            var anotherList = new List<int>();
            anotherList.Add(1);

            var names = new List<string>();
            names.Add("Mosh");
        }
    }
}

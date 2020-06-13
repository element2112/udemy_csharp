using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Generics
{
    // constraints
    // where T : IComparable
    // where T : Product
    // where T : struct (for value type)
    // where T : class (reference type)
    // where T : new() (has a default constructor)

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    // allows non nullable value types to act as nullable
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T); // default method returns the default value of whatever type is passed in
        }
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    // constraint to interface
    public class Utilities<T> where T : IComparable, new() // or can put constraints here. new() means it has to have a default constructor
    {
/*      public T Max<T>(T a, T b)
        {
            return a > b ? a : b; // can't compare don't know the type
        }*/

        public T Max(T a, T b) /*public T Max(T a, T b) where T : IComparable*/ // only does this method if the type passed is comparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

    }
}

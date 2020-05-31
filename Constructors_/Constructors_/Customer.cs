using System.Collections.Generic;

namespace Constructors_
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // snippet: ctor
        public Customer()
        {
            Orders = new List<Order>(); // always initialize lists to null in constructor

        }
        public Customer(int id) : this() // this intialization is similar to cpp
        {
            this.Id = id;
        }

        public Customer(int id, string name ) : this(id)
        {
            this.Name = name;
        }
    }
}

using System.Collections.Generic;

namespace Class_Fields
{
    partial class Program
    {
        
        public class Customer
        {
            public int Id;
            public string Name;
            // readonly makes it so fields are only initialiized once. Causes a compile error when initialization tries to happen again
            readonly public List<Order> Orders = new List<Order>(); // can initialize here because its good to only use constructors to initialize if initialization depends on user

            public Customer(int id)
            {
                this.Id = id;
            }

            public Customer(int id, string name) : this(id)
            {
                this.Name = name;
            }

            public void Promote()
            {
                // the below loses the list that was already initialized if the list initialzation is not set to readonly
/*                Orders = new List<Order>();*/

                // ....
            }
        }
    }
}

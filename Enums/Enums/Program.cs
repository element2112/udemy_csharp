using System;

namespace Enums
{
    public enum ShippingMethod : byte
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method); // prints 3

            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId); // prints express

            // enum to string
            Console.WriteLine(method.ToString());
            // console.writeline auto calls tostring for everything

            // string to enum
            var methodName = "Express";
            // parsing (turning string into a different type)
           var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            
        }
    }
}

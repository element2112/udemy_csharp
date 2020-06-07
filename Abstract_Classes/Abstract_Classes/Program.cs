namespace Abstract_Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();

            /*
             * Sealed Modifier:
             * 
             * sealed classes are the opposite of abstract classes
             * prevents derivation of calsses or overriding of methods
             * 
             * can be applied to a class or class method
             * 
             * sealed classes are slightly faster because of some run-time optimizations
             * but is hardly ever used
             * 
             */
        }
    }
}

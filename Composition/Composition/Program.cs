namespace Composition
{

    class Program
    {
        static void Main(string[] args)
        {
            var db = new DbMigrator(new Logger());
            // or
            var logger = new Logger();
            var installer = new Installer(logger);

            db.Migrate();
            installer.Install();
        }
    }
}

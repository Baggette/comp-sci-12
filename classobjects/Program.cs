namespace classobjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I love cars!");
            Car ford = new Car("Mustang", 420, "Red");
            ford.Drive();
            Car chevy = new Car("Camaro", 600, "Green");
            chevy.Drive();
            ford.Details();
        }
    }
}
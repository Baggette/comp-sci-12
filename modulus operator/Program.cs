namespace modulus_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes;
        
            Console.WriteLine("I can convert minutes to hours and minutes");
            Console.WriteLine("enter the time in minutes");
            minutes = int.Parse(Console.ReadLine());
            int hours = minutes / 60;
            int remainder = minutes % 60;
            Console.WriteLine($"The time is {hours} hours and {remainder} minutes(s)");
            Console.ReadKey();
        }
    }
}
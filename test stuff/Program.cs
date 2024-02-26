
namespace Program
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[] colours = { "green", "red", "purple", "blue", "yellow" };
            for (int i = 0; i < colours.GetLength(0); i++)
            {
                Console.WriteLine($"colours! {colours[i]}");
            }
        }
    }
}
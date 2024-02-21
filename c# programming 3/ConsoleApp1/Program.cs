class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("I can calculate the perimiter of your garden. What is your name?");
        string customer_name = Console.ReadLine();
        Console.WriteLine($"{customer_name} is your garden circular or rectangular? (c)ircular / (r)ectangular");
        string garden_type = Console.ReadLine().ToLower();
        if (garden_type == "c" || garden_type == "circular")
        {
            Console.WriteLine($"{customer_name} please tell me the diameter of your garden:");
            string input = Console.ReadLine();
            Convert.ToInt32(input);
            double garden_diameter = Convert.ToDouble(input);
            Console.WriteLine($"{customer_name} your garden perimiter is {garden_diameter * 3.1415926535897931} ft");
            Console.ReadKey();
        }
        else if (garden_type == "r" || garden_type == "rectangular")
        {
            Console.WriteLine($"{customer_name} please tell me the width of your garden");
            string str_width = Console.ReadLine();
            Console.WriteLine($"{customer_name} please tell me the length of your garden");
            string str_length = Console.ReadLine();
            double length = Convert.ToDouble(str_length);
            double width = Convert.ToDouble(str_width);
            Console.WriteLine($"{customer_name} the perimiter of your rectangular garden is {(length + width) * 2} ft");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"{customer_name} that doesn't appear to be a valid option");
            Console.ReadKey();
        }

    }
}
namespace Smooth
{
    class Program
    {

        public static void Main(String[] args)
        {
            //valid size of cup
            int[] cup_sizes = { 10, 12, 15, 20 };
            Console.WriteLine(@"Welcome to my smoothie shoppe! You may purchase some of our many amazing smoothies! 
Please tell me a size and number of ingredients so I may make your smoothie.
Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine(@"Available Sizes:
            Small - 10 oz
            Medium - 12 oz
            Large - 15 oz
            XLarge - 20 oz");

            Console.WriteLine("What size would you like?");
            //read user input and set it to cup_size variable
            int cup_size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many ingredients would you like? (You can have upto 10!)");
            //read user input and set it to ingredients 
            int ingredients = Convert.ToInt32(Console.ReadLine());

            //validate that the user inputted a valid cup size
            if (!cup_sizes.Contains(cup_size))
            {
                Console.WriteLine($"Sorry! {cup_size} oz is not a valid size.");
                Console.ReadKey();
            } //validate that the user inputted a valid amount of ingredients
            else if (ingredients >= 11 || ingredients <= 0)
            {
                Console.WriteLine($"Sorry! {ingredients} is not a valid amount of ingredients");
                Console.ReadKey();
            }
            else
            {
                //calculate total
                Console.WriteLine($"Your total is : {(0.10 * ingredients * cup_size) + 1.75}$");
                Console.ReadKey();
            }
        }
    }
}
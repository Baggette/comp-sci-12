

namespace shirtty_shirts
{
    internal class Program
    {
        //set amount of shirts available
        public static IDictionary<string, int> inventory = new Dictionary<string, int>() {
            {"small", 55},
            {"medium", 42},
            {"large", 50 },
            {"x-large", 35},
        };
        public static int Percentage(int total, int amount, int price)
        {
            //calculate the percentage discount 
            double num1 = (amount * price) - total; //10 - 8
            double percentage = num1 / (amount * price); //2 10
            return Convert.ToInt32(percentage * 100);
        }
        public static void Total(string size, int amount, int price)
        {
            Console.WriteLine($"Your subtotal before taxes and discounts for {amount} shirts is {amount * price} $");
            Console.WriteLine("If you have dicount code please enter it (do not try 20percent as a discount code mhm):");
            //check if the user inputted the 20percent discount code
            string discount = Console.ReadLine();
            //set the total variable to the amount that the user must pay by using the Discount method
            int total = Convert.ToInt32(Discount(discount, amount, price));
            //add on the tax
            double total_with_tax = total * 1.12;
            //print how much the user must pay and other information such as how many shirts they bought and discounts
            Console.WriteLine($"Your total is {total_with_tax.ToString("N")}$ with 5% gst and 7 % pst \nFor {amount} {size} shirts with a {Percentage(total, amount, price)}% discount");
            string exit;
            //prompt user if they want to exit
            do
            {
                Console.WriteLine("Press enter to continue or exit to exit");
                exit = Console.ReadLine().ToLower();
                //check user input, if its exit, exit if not continue
                if (exit == "exit") return;
                //execute the Main method
               Main();
            } while (exit != "exit");
        }
        public static int Discount(string discount, int amount, int price)
        {
            //check if the user input a valid discount code and if they did return the discount price
            switch (discount)
            {
                case "20percent":
                    double percentage = (amount * price) * .2;
                    double total = (amount * price - percentage); 
                    return Convert.ToInt32(total);
                case "almostfree":
                    double percentage2 = (amount * price) * .99;
                    double total2 = (amount * price - percentage2);
                    return Convert.ToInt32(total2);
                case "skibidi toilet":
                    double percentage3 = (amount * price) * .69;
                    double total3 = (amount * price - percentage3);
                    return Convert.ToInt32(total3);
                default:
                    return amount * 10;
            }
        }
        public static void Calculate(string size, int amount)
        {
            //uses switch statement to execute the method with the correct values
            switch (size)
            {
                case "small":
                    //passes the size variable, amount of shrits and the amount each one costs
                    Total(size, amount, 10);
                    break;
                case "medium":
                    Total(size, amount, 12);
                    break;
                case "large":
                    Total(size, amount, 15);
                    break;
                case "x-large":
                    Total(size, amount, 20);
                    break;
            }
        }
        public static void CheckInventory(string input, int num)
        {
            //check and iterate through and execute the corrosponding if else statement based on the input given 
            if (input == "s" || input == "small")
            {
                if (num > inventory["small"] || num <= 0)
                {
                    Console.WriteLine("Im sorry we dont seem to have enough shirts for you.");
                    Main();
                }
                else 
                {
                    //updates inventory to reflect the amount of shirts bought
                    inventory["small"] = inventory["small"] - num;
                    //executes the calculate method with the size the user selected and the amount of shirts they wanted (in this case size small however each other else if statement does the same with the correct size
                    Calculate("small", num);
                }
            }else if (input == "m" || input == "medium")
            {
                if (num > inventory["medium"] || num <= 0)
                {
                    Console.WriteLine("Im sorry we dont seem to have enough shirts for you.");
                    Main();
                }
                else
                {
                    inventory["medium"] = inventory["medium"] - num;
                    Calculate("medium", num);
                }
            }else if (input == "l" || input == "large")
            {
                if (num > inventory["large"] || num <= 0)
                {
                    Console.WriteLine("Im sorry we dont seem to have enough shirts for you.");
                    Main();
                }
                else
                {
                    inventory["large"] = inventory["large"] - num;
                    Calculate("large", num);
                }
            }else if (input == "xl" || input == "x-large")
            {
                if (num > inventory["x-large"] || num <= 0)
                {
                    Console.WriteLine("Im sorry we dont seem to have enough shirts for you.");
                    Main();
                }
                else
                {
                    inventory["x-large"] = inventory["x-large"] - num;
                    Calculate("x-large", num);
                }
            }
        }
        static void Main()
        {
            string input;
            //declare what inputs are considered valid
            string[] valid_sizes = { "small", "medium", "large", "x-large", "s", "m", "l,", "xl" };
            string[] alias = { "s", "m", "l", "xl" };
            Console.WriteLine("Welcome to my t-shirt shop.");
            Console.WriteLine("");
            Console.WriteLine($"Available sizes: \n Small - 10$: {inventory["small"]} available \n Medium - 12$: {inventory["medium"]} available \n Large - 15$: {inventory["large"]} available \n X-Large - 20$: {inventory["x-large"]} available");
            Console.WriteLine("");
            Console.WriteLine("What size would you like?:");
            //convert input to lowercase
            input = Console.ReadLine().ToLower();
            //check if input contains any strings from the valid_sizes array
            if (valid_sizes.Contains(input))
            {
                Console.WriteLine("How many would you like?");
                int num = Convert.ToInt32(Console.ReadLine());
                //execute checkinventory method which verifies that there is enough inventory
                CheckInventory(input, num);
            }
            else
            {
                //if the user did not input a valid option just rerun main
                Console.WriteLine("Sorry that was not a valid option");
                Main();
            }
        }
    }
}
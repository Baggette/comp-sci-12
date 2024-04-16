using System.Net.NetworkInformation;
using System.Net.Security;

namespace random_num
{
    internal class Program
    {
        public static int number_1;
        public static int number_2;

        public static void Rerun()
        {
            string exit = "";
            do
            {
                Console.WriteLine("Press enter to continue or exit to exit");
                exit = Console.ReadLine().ToLower();
                if (exit == "exit") return;
                Main();
            } while (exit != "exit"); 
        }
        public static void ChonkerOrNot()
        {
            //check if the numbers are equal to each other
            if (number_1 == number_2)
            {
                Console.WriteLine($"{number_1} and {number_2} are the same!");
                Console.ReadKey();
                //execute method that checks if user wants to exit or not
                Rerun();
            }//check if number_1 is greater than number number_2
            else if (number_1 > number_2)
            {
                Console.WriteLine($"{number_1} is larger than {number_2}!");
                Console.ReadKey();
                Rerun();
            }//check if number_1 is lesser than number_2
            else if (number_1 < number_2)
            {
                Console.WriteLine($"{number_1} is lesser than {number_2}!");
                Console.ReadKey();
                Rerun();
            } 
            
        }
        public static void NumGen(int input)
        {
            //generate random numbers
            Random rand = new Random();
            //set the value of the random number to the number_1 variable
            number_1 = rand.Next(1,input);
            Console.WriteLine(number_1);
            //generate the second number and set its value to the number_2 variable
            number_2 = rand.Next(1,input);
            Console.WriteLine(number_2);
            //execute the method that checks which number is higher or lower
            ChonkerOrNot();
        }
        static void Main()
        {
            Console.WriteLine("please enter the max number");
            int input = Convert.ToInt32(Console.ReadLine());
            //check user input and if its over 200 or under 1 set it to 200 if not set it to input
            if (input < 1 || input > 200)
            {
                Console.WriteLine("Your input was greater than 200 or less than 1 so it has been set to 200");
                //execute numgen software
                NumGen(200);
            }
            else 
            {
                NumGen(input);
            }
        }
    }
}
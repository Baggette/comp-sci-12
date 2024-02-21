using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void func(string name, int age)
        {
            while (age <= 10000000)
            {   
                Random random = new Random();
                int length = age;
                string chars = $"{name}";
                Console.WriteLine(name);
                Console.WriteLine(age.ToString());
                age++;
                string s = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
                Console.WriteLine(s);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("whats your name");
            string name = Console.ReadLine();
            Console.WriteLine("whats your age");
            int age = Convert.ToInt32(Console.ReadLine());
            func(name, age);
        }
    } 
}
using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your number weird?\n");

            string answer;
            do
            {
                Console.WriteLine("Enter a number to find out.");

                int n = Int32.Parse(Console.ReadLine());

                if (n % 2 != 0)
                {
                    Console.WriteLine("Weird");
                    Console.ReadLine();
                    
                }
                if (n % 2 == 0 && n >= 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                    Console.ReadLine();
                    
                }
                if (n % 2 == 0 && n >= 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                    Console.ReadLine();
                   
                }
                if (n % 2 == 0 && n > 20)
                {
                    Console.WriteLine("Not Weird");
                    Console.ReadLine();
                   
                }
                if (n == 69)
                {
                    Console.WriteLine("Nice");
                    Console.ReadLine();
                    
                }
                if (n > 100)
                {
                    Console.WriteLine("Let's be reasonble. 1 - 100 please.");
                    Console.ReadLine();
                   
                }
                Console.WriteLine("Want to try another number? yes/no");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer.Equals("yes", StringComparison.OrdinalIgnoreCase));


        }
    }
}

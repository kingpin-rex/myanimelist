using System;
namespace StanbicIbtc
{
    class Program
    {  //This method starts the application
        static void Main(string[] args)
        {
            var count = 95.00;
            count = 77;//Strongly typed
            bool isSuccessful = true;
            char letter = 'J';
            const string name = "Benedict";
            double amount = 67.98D;
            string tax = "30";
            int value = Convert.ToInt16(tax);

            Console.Write("What is your age?:   ");
            string age = Console.ReadLine();
            int sum = Convert.ToInt32(age) *10;


            Console.WriteLine($"My age times 10 is {sum}");

            Console.WriteLine(count);
            Console.WriteLine(isSuccessful);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            Console.WriteLine(amount);
            Console.WriteLine(name + " Jannet");
            
        }
    }
}
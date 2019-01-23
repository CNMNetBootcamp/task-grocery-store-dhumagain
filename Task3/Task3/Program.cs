using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good
            //setup
            int numberOfBottles = 0;
            int response = 0;
            double unitPrice = 0.10;
            double amountPaid = 0.0;

           
            //input
            for (int day = 1; day < 8; day++)
            {
                Console.WriteLine("Enter number of bottles collected on Day " + day);

                response = int.Parse(Console.ReadLine());

                numberOfBottles = numberOfBottles + response;

            }
            //processing and output
            amountPaid = numberOfBottles * unitPrice;

            Console.WriteLine("Total number of bottles collected this week was " + numberOfBottles +
                " and the total amount paid for bottles is $" + amountPaid);
            
            Console.ReadLine();
        }
    }
}


using System;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public int totalFair(int distanceInKm, int timeInMinute )
        {
            //variable initialize
            int perKilometer = 10;
            int perMinute = 1;
            int Minimum = 5;

            //calculate total fair
            int totalCost = Minimum + (perKilometer * distanceInKm) + (perMinute * timeInMinute);
            return totalCost;
        }
        public static void Main(string[] args)
        {
            //Print welcome message
            Console.WriteLine("Welcome to cab invoice generator");
        }
    }
}

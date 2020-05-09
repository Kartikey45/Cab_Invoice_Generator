using System;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        //variable initialize
        int numberOfRides = 5;

        //Calculate total fair of a single journey
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

        //Calculate the aggregate total fair of multiple rides
        public int aggregateFare()
        {
            //variable initialize
            int aggregateFare = 0;
            
            //create instance variable
            InvoiceGenerator cabInvoice = new InvoiceGenerator();
            
            //calculate aggregate fare according to total no. of rides
            for (int ride = 1; ride <= numberOfRides; ride++)
            {
                aggregateFare = aggregateFare + cabInvoice.totalFair(5, 60);
            }
            return aggregateFare;
        }

        //Total nuber of rides
        public int totalNumberOfRides()
        {
            return numberOfRides;
        }

        //Average fare per ride
        public int averagFarePerRide()
        {
            //create instance variable 
            InvoiceGenerator cabInvoice = new InvoiceGenerator();
            
            //calculate average fare
            int average = (cabInvoice.aggregateFare() / totalNumberOfRides());
            
            return average;
        }
    }
}

using System;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        
        //Calculate total fair of a single journey
        public int totalFair(int distanceInKm, int timeInMinute )
        {
            //variable initialize
            int perKilometer = 10;
            int perMinute = 1;
            int Minimum = 5;

            //calculate total fair
            int totalCost = (perKilometer * distanceInKm) + (perMinute * timeInMinute);
            return Math.Max(totalCost,Minimum);
        }

        //Calculate the aggregate fare, average far and total number of rides 
        public Tuple<int,int,double> aggregateFare(int numberOfRides)
        {
            //variable initialize
            int aggregateFare = 0;
            int totalNumbeOfRides = 0;
            
            //create instance variable
            InvoiceGenerator cabInvoice = new InvoiceGenerator();
            
            //calculate aggregate fare according to total no. of rides
            for (int ride = 1; ride <= numberOfRides; ride++)
            {
                aggregateFare = aggregateFare + cabInvoice.totalFair(5, 60);
                totalNumbeOfRides++;
            }

            double averageFarePerRide = aggregateFare / totalNumbeOfRides;

            return new Tuple<int,int,double>(aggregateFare, totalNumbeOfRides, averageFarePerRide);
        }
    }
}

using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
       //Invoice generator should return total fai r for the journey
        [Test]
        public void totalFairForJourney()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            int Fair = generate.totalFair(5,60);
            Assert.AreEqual(115, Fair);
        }

        //calculate aggregate fare according to total no. of rides
        [Test]
        public void agregatefare()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            int aggregate = generate.aggregateFare();
            Assert.AreEqual(aggregate,575);
        }
        
        //Total number of rides
        [Test]
        public void totalRides()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            int totalrides = generate.totalNumberOfRides();
            Assert.AreEqual(5, totalrides);
        }

        //Average fare per ride
        [Test]
        public void AverageFarePerRide()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            int averageFare = generate.averagFarePerRide();
            Assert.AreEqual(115, averageFare);
        }
    }
}
using NUnit.Framework;
using CabInvoiceGenerator;
using System;

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
            Assert.AreEqual(110, Fair);
        }

        //calculate aggregate fare
        [Test]
        public void EnhancedInvoiceAggregateFair()
        {
            Ride[] ride = { new Ride(5,60), new Ride(4,50), new Ride(3,40) };
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> aggregate = generate.aggregateFare(ride);
            Assert.AreEqual(aggregate.Item1,270);
        }

        //calculate Average fare
        [Test]
        public void EnhancedInvoiceAveragefare()
        {
            Ride[] ride = { new Ride(5, 60), new Ride(4, 50), new Ride(3, 40) };
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> average = generate.aggregateFare(ride);
            Assert.AreEqual(average.Item3,90);
        }

        //Calculate total number of rides
        [Test]
        public void EnhancedInvoiceTotalNumberOfRides()
        {
            Ride[] ride = { new Ride(5, 60), new Ride(4, 50), new Ride(3, 40) };
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> average = generate.aggregateFare(ride);
            Assert.AreEqual(average.Item2,3);
        }
    }
}
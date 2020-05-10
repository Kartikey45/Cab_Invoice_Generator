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
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> aggregate = generate.aggregateFare(5);
            Assert.AreEqual(aggregate.Item1,550);
        }

        //calculate Average fare
        [Test]
        public void EnhancedInvoiceAveragefare()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> average = generate.aggregateFare(5);
            Assert.AreEqual(average.Item3,110);
        }

        //Calculate total number of rides
        [Test]
        public void EnhancedInvoiceTotalNumberOfRides()
        {
            InvoiceGenerator generate = new InvoiceGenerator();
            Tuple<int, int, double> average = generate.aggregateFare(5);
            Assert.AreEqual(average.Item2,5);
        }
    }
}
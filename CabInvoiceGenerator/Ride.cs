using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        //variable initialize
        public int distanceInKm;
        public int timeInMinute;

        public Ride(int distanceInKm, int timeInMinute)
        {
            this.distanceInKm = distanceInKm;
            this.timeInMinute = timeInMinute;
        }
    }
}

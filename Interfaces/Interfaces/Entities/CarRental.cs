using System;

namespace Interfaces.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehical Vehical { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehical vehical)
        {
            Start = start;
            Finish = finish;
            Vehical = vehical;
        }
    }
}

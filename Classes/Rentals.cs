
using System;
using Customer = brandwerk.Function.Classes.Customer;
using Vehicle = brandwerk.Function.Classes.Vehicle;

namespace brandwerk.Function.Classes
{
    public class Rentals
    {
        public Customer customer = new Customer();

        public DateTime created_at = DateTime.Now;

        public DateTime updated_at = DateTime.Now;

        public Vehicle vehicle = new Vehicle();

        public DateTime rentedFrom;

        public DateTime rentedTill;

        public string status;

        public string type = "Standard";

        


    }

}
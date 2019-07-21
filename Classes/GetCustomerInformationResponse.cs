using System.Collections.Generic;
using Rentals = brandwerk.Function.Classes.Rentals;

namespace brandwerk.Function.Classes
{
    public class GetCustomerInformationResponse
    {
        public List<Rentals> rentals = new List<Rentals>();

        public GetCustomerInformationResponse()
        {
            this.rentals.Add(new Rentals());
            this.rentals.Add(new Rentals());
            this.rentals.Add(new Rentals());
            this.rentals.Add(new Rentals());
        }
    }
}
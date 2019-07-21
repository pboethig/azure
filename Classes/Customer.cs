
using System;
using Address = brandwerk.Function.Classes.Address;
using System.Collections.Generic;

namespace brandwerk.Function.Classes
{
    public class Customer
    {
          public string type = "private";

          public DateTime created_at = DateTime.Now;
  
          public List<Address> addresses = new List<Address>();

          public string email;

          public string username;

          public Customer()
          {
              this.addresses.Add(new Address());
              this.addresses.Add(new Address());
              this.addresses.Add(new Address());
          }
    }  
}
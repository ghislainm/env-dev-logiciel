using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo21Nov
{
    public class Customer
    {
        public double AccountBalance { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string Remark { get; set; }

        public Customer(double a,string ad1,string ad2,string c,string co,string e,long id, string n, string pc, string r)
        {
            AccountBalance = a;
            AddressLine1 = ad1;
            AddressLine2 = ad2;
            City = c;
            Country = co;
            Email = e;
            Id = id;
            Name = n;
            PostCode = pc;
            Remark = r;
        }
    }
}

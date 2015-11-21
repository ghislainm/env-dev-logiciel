using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo21Nov
{
    public class CompanyContext : DbContext
    {
        public DbSet<Customer>  Customers{ get; set; }
        public CompanyContext()
        : base(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3A3;User ID=IG3A3;Password=pwUserdb19")
        {

        }
       
    }
}

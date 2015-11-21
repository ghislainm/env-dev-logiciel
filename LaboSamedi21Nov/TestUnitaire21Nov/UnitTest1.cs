using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Labo21Nov;
using System.Linq;


namespace TestUnitaire21Nov
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            CompanyContext CpyCtx = new CompanyContext();
            Customer customer = new Customer(100.2,"Rue de glimes,3","rue joephine rauscent", "Jodoigne", "Belgique", "abcd@hotmail.com",1,"Ghislain","1370","A livrer");

            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            CpyCtx.Customers.Add(customer);
            CpyCtx.SaveChanges();

            TestMethod2();
        }

        public void TestMethod2()
        {
            CompanyContext CpyTxt = new CompanyContext();
            int nbrCutsomer = CpyTxt.Customers.Count();

            Assert.AreNotEqual('0', nbrCutsomer);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;
using ConsoleApplicationLabo1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pupil p = new Pupil("ghis",20);
            Activity a = new Activity("env dev", false);
            p.addActivity(a);

            p.AddEvaluation("env dev", 'd');

            var evaluation = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GetEvaluationFor_ThrowsExceptionForUnknownActivity()
        {
            Pupil p = new Pupil("ghis", 20);

            var evaluation = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', evaluation); 
        }
    }
}

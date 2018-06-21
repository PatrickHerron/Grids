
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstGridProject;
using FirstGridProject.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimulationController sim = new SimulationController();
            Assert.AreEqual(2.345, sim.GetRunTime());
        }
    }
}

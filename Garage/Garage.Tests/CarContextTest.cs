using Garage.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Tests
{
    [TestClass]
    public class CarContextTest
    {
        [TestMethod]
        public void MakeSave()
        {
            Make make = new Make(){MakeName = "BMW"};
            using (CarContext cc = new CarContext())
            {
                cc.Makes.Add(make);
                cc.SaveChanges();

            }

            Make savedMake;

            using (CarContext cc = new CarContext())
            {
                savedMake = cc.Makes.Where(m=>m.MakeName=="BMW").Single();
            }

            Assert.AreEqual(make.MakeID, savedMake.MakeID);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2Day3homeworkv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2.Tests
{
    [TestClass()]
    public class HumanTests
    {
        [TestMethod()]
        public void HumanTest()
        {
            Human myTestHuman = new Human("Brown");
            Assert.IsNotNull(myTestHuman.HairColor);
            Assert.AreEqual(2, myTestHuman.NumLegs());
            Assert.AreEqual(1, myTestHuman.AvgNumOffspring());
            Assert.AreEqual(null, myTestHuman.Name);
            myTestHuman.Name = "Jim";
            Assert.AreEqual("Jim", myTestHuman.Name);
            Assert.AreEqual(null, myTestHuman.Species);
            myTestHuman.Name = "Developer";
            Assert.AreEqual("Developer", myTestHuman.Species);
            Assert.AreEqual(null, myTestHuman.ExternalCovering);
            myTestHuman.Name = "Skin";
            Assert.AreEqual("Skin", myTestHuman.ExternalCovering);
        }

        [TestMethod()]
        public void HumanTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void NumLegsTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void AvgNumOffspringTest()
        {
            //Assert.Fail();
        }
    }
}
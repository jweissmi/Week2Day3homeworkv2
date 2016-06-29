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
            Assert.AreEqual(null, myTestHuman.Name);
            myTestHuman.Name = "Jim";
            Assert.AreEqual("Jim", myTestHuman.Name);
            Assert.AreEqual(null, myTestHuman.Species);
            myTestHuman.Species = "Developer";
            Assert.AreEqual("Developer", myTestHuman.Species);
            Assert.AreEqual(null, myTestHuman.ExternalCovering);
            myTestHuman.ExternalCovering = "Skin";
            Assert.AreEqual("Skin", myTestHuman.ExternalCovering);
        }

        [TestMethod()]
        public void HumanTest1()
        {
            Human myTestHuman = new Human("Brown");
            Assert.IsNotNull(myTestHuman.HairColor);
            Assert.AreEqual(null, myTestHuman.Name);
            myTestHuman.Name = "Jim";
            Assert.AreEqual("Jim", myTestHuman.Name);
            Assert.AreEqual(null, myTestHuman.Species);
            myTestHuman.Species = "Developer";
            Assert.AreEqual("Developer", myTestHuman.Species);
            Assert.AreEqual(null, myTestHuman.ExternalCovering);
            myTestHuman.ExternalCovering = "Skin";
            Assert.AreEqual("Skin", myTestHuman.ExternalCovering);
        }

        [TestMethod()]
        public void NumLegsTest()
        {
            Human myTestHuman = new Human("Brown");
            Assert.AreEqual(2, myTestHuman.NumLegs());
        }

        [TestMethod()]
        public void AvgNumOffspringTest()
        {
            Human myTestHuman = new Human("Brown");
            Assert.AreEqual(1, myTestHuman.AvgNumOffspring());
        }
    }
}
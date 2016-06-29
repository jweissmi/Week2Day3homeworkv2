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
    public class LizardTests
    {
        [TestMethod()]
        public void LizardTest()
        {
            Lizard myTestLizard = new Lizard();
            Assert.IsNull(myTestLizard.Name);
            Assert.AreEqual(null, myTestLizard.Name);
            myTestLizard.Name = "Larry";
            Assert.AreEqual("Larry", myTestLizard.Name);
            Assert.AreEqual(null, myTestLizard.Species);
            myTestLizard.Species = "Lounge Lizard";
            Assert.AreEqual("Lounge Lizard", myTestLizard.Species);
            Assert.AreEqual(null, myTestLizard.ExternalCovering);
            myTestLizard.ExternalCovering = "Scales";
            Assert.AreEqual("Scales", myTestLizard.ExternalCovering);
        }

        [TestMethod()]
        public void IsDesertDwellerTest()
        {
            Lizard myTestLizard = new Lizard();
            Assert.AreEqual(true, myTestLizard.IsDesertDweller()); 
        }
    }
}
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
    public class DogTests
    {
        [TestMethod()]
        public void DogTest()
        {
            Dog myTestDog = new Dog("Gernman Shepard");
            Assert.IsNotNull(myTestDog.DogBreed);
            Assert.AreEqual(null, myTestDog.Name);
            myTestDog.Name = "Rusty";
            Assert.AreEqual("Rusty", myTestDog.Name);
            Assert.AreEqual(null, myTestDog.Species);
            myTestDog.Species = "Canine";
            Assert.AreEqual("Canine", myTestDog.Species);
            Assert.AreEqual(null, myTestDog.ExternalCovering);
            myTestDog.ExternalCovering = "Fur";
            Assert.AreEqual("Fur", myTestDog.ExternalCovering);
        }

        [TestMethod()]
        public void DogTest1()
        {
            Dog myTestDog = new Dog("Gernman Shepard");
            Assert.IsNotNull(myTestDog.DogBreed);
            Assert.AreEqual(null, myTestDog.Name);
            myTestDog.Name = "Rusty";
            Assert.AreEqual("Rusty", myTestDog.Name);
            Assert.AreEqual(null, myTestDog.Species);
            myTestDog.Species = "Canine";
            Assert.AreEqual("Canine", myTestDog.Species);
            Assert.AreEqual(null, myTestDog.ExternalCovering);
            myTestDog.ExternalCovering = "Fur";
            Assert.AreEqual("Fur", myTestDog.ExternalCovering);
        }

        [TestMethod()]
        public void NumLegsTest()
        {
            Dog myTestDog = new Dog("German Shepard");
            Assert.AreEqual(4, myTestDog.NumLegs());
        }

        [TestMethod()]
        public void AvgNumOffspringTest()
        {
            Dog myTestDog = new Dog("German Shepard");
            Assert.AreEqual(6, myTestDog.AvgNumOffspring());
        }
    }
}
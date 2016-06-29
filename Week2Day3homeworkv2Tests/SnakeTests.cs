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
    public class SnakeTests
    {
        [TestMethod()]
        public void SnakeTest()
        {
            Snake MyTestSnake = new Snake();
            Assert.IsNull(MyTestSnake.Name);
            Assert.AreEqual(null, MyTestSnake.Name);
            MyTestSnake.Name = "Sam";
            Assert.AreEqual("Sam", MyTestSnake.Name);
            Assert.AreEqual(null, MyTestSnake.Species);
            MyTestSnake.Species = "Rattler";
            Assert.AreEqual("Rattler", MyTestSnake.Species);
            Assert.AreEqual(null, MyTestSnake.ExternalCovering);
            MyTestSnake.ExternalCovering = "Scales";
            Assert.AreEqual("Scales", MyTestSnake.ExternalCovering);
        }

        [TestMethod()]
        public void IsVenomousTest()
        {
            Snake MyTestSnake = new Snake();
            Assert.AreEqual(true, MyTestSnake.IsVenomous());
        }
    }
}
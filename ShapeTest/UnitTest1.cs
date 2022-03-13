using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape; 
using System;

namespace ShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangle trg = new Triangle(3, 3, 3);
            Triangle trg1 = new Triangle(2, 1, 1);
            double res = 3.897;  
            Assert.AreEqual(trg.Squer(), res);
            Assert.AreEqual(trg1.Squer(), 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Circule crc = new Circule(2);
            double res = 12.566370614359172;
            Assert.AreEqual(crc.Squer(), res); 
        }

        [TestMethod]
        public void TestMethod3()
        {
            Triangle trg = new Triangle(0, 0, 0);
            var exception = Assert.ThrowsException<ArgumentException>(() => trg.Squer()); 
            Assert.AreEqual("There is no such triangle", exception.Message);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Triangle trg = new Triangle(1, 0, 0);
            var exception = Assert.ThrowsException<ArgumentException>(() => trg.Squer());
            Assert.AreEqual("There is no such triangle", exception.Message);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Triangle trg = new Triangle(1, 1, 0);
            var exception = Assert.ThrowsException<ArgumentException>(() => trg.Squer());
            Assert.AreEqual("There is no such triangle", exception.Message);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Triangle trg = new Triangle(1, 1, 3);
            var exception = Assert.ThrowsException<ArgumentException>(() => trg.Squer());
            Assert.AreEqual("There is no such triangle", exception.Message);
        }
    }
}

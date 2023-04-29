using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kakish;

namespace kakich_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Program.izum(2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual(4, Program.izum(3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(Program.kuraga());
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(Program.kulich());
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsNull(Program.yaichko());
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsNotNull(Program.luzin());
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsNotInstanceOfType(Program.izum(2), typeof(double));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsInstanceOfType(Program.izum(2), typeof(int));
        }
        [TestMethod]
        public void TestMethod9()
        {
            StringAssert.Contains("ганс красава, собянин молодец", Program.aleksei());
        }
    }
}

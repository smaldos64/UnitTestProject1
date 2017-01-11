using UnitTestProject1.Models;
using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;
using UnitTestProject1.Controllers;
using Microsoft.CSharp.RuntimeBinder;


namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController Controller = new HomeController();

            ViewResult Result = Controller.Index() as ViewResult;

            Assert.AreEqual("Hello Lars !!!", Result.ViewBag.Message);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            int Number1 = 10;
            int Number2 = 20;
            int Number3;

            Number3 = TestUnitClass.Add_Numbers(Number1, Number2);

            Assert.AreEqual(30, Number3);

            Number3 = TestUnitClass.Subtract_Numbers(Number1, Number2);

            Assert.AreEqual(-11, Number3);
        }

        [TestMethod()]
        public void Add_NumbersTest()
        {
            int Number1 = 11;
            int Number2 = 20;
            int Number3;

            Number3 = TestUnitClass.Add_Numbers(Number1, Number2);

            Assert.AreEqual(31, Number3);
            //Assert.Fail();
        }
    }
}

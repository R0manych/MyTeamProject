using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;
using System.Web.Mvc;

namespace Web.Tests.Controllers
{
    [TestClass]
    public class MyControllerTest
    {
        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            MyController controller = new MyController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void IndexStringInViewbag()
        {
            MyController controller = new MyController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual("My controller method", result.ViewBag.Message);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;
using System.Web.Mvc;

namespace Web.Tests.Controllers
{
    [TestClass]
    public class StoreControllerTest
    {
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            StoreController controller = new StoreController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            StoreController controller = new StoreController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void IndexStringInViewbag()
        {
            StoreController controller = new StoreController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual("Hello world!", result.ViewBag.Message);
        }
    }
}

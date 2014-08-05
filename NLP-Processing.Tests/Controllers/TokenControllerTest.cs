using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLP_Processing;
using NLP_Processing.Controllers;

namespace NLP_Processing.Tests.Controllers
{
    [TestClass]
    public class TokenControllerTest
    {
        [TestMethod]
        public void GetList()
        {
            // Arrange
            TokenController controller = new TokenController();

            // Act
            var parms = "A cat is an animal";
            var result = controller.Get(parms);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            TokenController controller = new TokenController();

            // Act
            string result = controller.Get("dog");

            // Assert
            Assert.AreEqual("value", result);
        }
    }
}

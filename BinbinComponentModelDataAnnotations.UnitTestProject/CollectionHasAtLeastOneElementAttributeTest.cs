using System;
using System.Collections.ObjectModel;
using Binbin.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinbinComponentModelDataAnnotations.UnitTestProject
{
    [TestClass]
    public class CollectionHasAtLeastOneElementAttributeTest
    {
        [TestMethod]
        public void TestMethod11()
        {
            var value = new Array[3, 3];
            var attribute = new CollectionHasAtLeastOneElementAttribute();
            Assert.IsTrue(attribute.IsValid(value));
        }
        [TestMethod]
        public void TestMethod12()
        {
            var value = new string[] { };
            var attribute = new CollectionHasAtLeastOneElementAttribute();
            Assert.IsFalse(attribute.IsValid(value));
        }
        [TestMethod]
        public void TestMethod21()
        {
            var value = new Collection<string>() { "slk", "" };
            var attribute = new CollectionHasAtLeastOneElementAttribute();
            Assert.IsTrue(attribute.IsValid(value));
        }
        [TestMethod]
        public void TestMethod22()
        {
            var value = new Collection<string>() { };
            var attribute = new CollectionHasAtLeastOneElementAttribute();
            Assert.IsFalse(attribute.IsValid(value));
        }
    }
}

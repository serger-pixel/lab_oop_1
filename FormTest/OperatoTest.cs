using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_1;

namespace FormTest
{
    [TestClass]
    public class OperatorTest
    {
        [TestMethod]
        public void getNameTest()
        {
            String expected = "TestOperator";
            InternetOperator local = new InternetOperator(expected);
            Assert.AreEqual(expected, local.getNameOperator());
        }

        [TestMethod]
        public void getPriceTest()
        {
            decimal expected = 20.5m;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, expected);
            Assert.AreEqual(expected, local.getPriceOfMonth());
        }

        [TestMethod]
        public void getCntUsersTest()
        {
            int expected = 50;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, IntOperConsts.PRICE, expected);
            Assert.AreEqual(expected, local.getCntUsers());
        }

        [TestMethod]
        public void getSpeedMbTest()
        {
            int expected = 512;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, IntOperConsts.PRICE, IntOperConsts.CNTUSERS, expected);
            Assert.AreEqual(expected, local.getSpeedMb());
        }

        [TestMethod]
        public void getSupport5gTest()
        {
            bool expected = true;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, IntOperConsts.PRICE, IntOperConsts.CNTUSERS, IntOperConsts.SPEED, expected);
            Assert.AreEqual(expected, local.getSupport5g());
        }

        [TestMethod]
        public void getFamilySharingTest()
        {
            bool expected = true;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, IntOperConsts.PRICE, IntOperConsts.CNTUSERS, IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, expected);
            Assert.AreEqual(expected, local.getFamilySharing());
        }

        [TestMethod]
        public void getRoutArendTest()
        {
            bool expected = true;
            InternetOperator local = new InternetOperator(IntOperConsts.NAME, IntOperConsts.PRICE, IntOperConsts.CNTUSERS, IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, expected);
            Assert.AreEqual(expected, local.getRoutArend());
        }
    }
}
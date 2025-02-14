using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_1;
using System.Text.RegularExpressions;

namespace FormTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void ValidateNameTest_Valid()
        {
            string name = "TestOperator";
            bool isValid = Regex.IsMatch(name, Regs._nameReg);
            Assert.IsTrue(isValid, ExceptionMessages.NAMEEXCEP);
        }

        [TestMethod]
        [ExpectedException(typeof(NameException))]
        public void ValidateNameTest_Invalid_StartsWithLowercase()
        {
            string name = "testOperator";
            if (!Regex.IsMatch(name, Regs._nameReg))
            {
                throw new NameException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NameException))]
        public void ValidateNameTest_Invalid_TooLong()
        {
            string name = "ThisIsAVeryLongOperatorNameWithMoreThanTwentyCharacters";
            if (!Regex.IsMatch(name, Regs._nameReg))
            {
                throw new NameException();
            }
        }

        [TestMethod]
        public void ValidatePriceTest_Valid()
        {
            string price = "100000";
            bool isValid = Regex.IsMatch(price, Regs._priceReg);
            Assert.IsTrue(isValid, ExceptionMessages.PRICEEXCEP);
        }

        [TestMethod]
        [ExpectedException(typeof(PriceException))]
        public void ValidatePriceTest_Invalid_TooLow()
        {
            string price = "99";
            if (!Regex.IsMatch(price, Regs._priceReg))
            {
                throw new PriceException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(PriceException))]
        public void ValidatePriceTest_Invalid_TooHigh()
        {
            string price = "100001";
            if (!Regex.IsMatch(price, Regs._priceReg))
            {
                throw new PriceException();
            }
        }

        [TestMethod]
        public void ValidateCntUsersTest_Valid()
        {
            string cntUsers = "50";
            bool isValid = Regex.IsMatch(cntUsers, Regs._cntUsersReg);
            Assert.IsTrue(isValid, ExceptionMessages.CNTUSERSEXCEP);
        }

        [TestMethod]
        [ExpectedException(typeof(CntUsersException))]
        public void ValidateCntUsersTest_Invalid_TooHigh()
        {
            string cntUsers = "101";
            if (!Regex.IsMatch(cntUsers, Regs._cntUsersReg))
            {
                throw new CntUsersException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(CntZeroUsers))]
        public void ValidateCntUsersTest_Invalid_Zero()
        {
            int cntUsers = Regs.zeroUsers;
            if (cntUsers == Regs.zeroUsers)
            {
                throw new CntZeroUsers();
            }
        }

        [TestMethod]
        public void ValidateSpeedTest_Valid()
        {
            int speed = 1024;
            bool isValid = speed >= Regs.minSpeed && speed <= Regs.maxSpeed;
            Assert.IsTrue(isValid, ExceptionMessages.SPEEDEXCEP);
        }

        [TestMethod]
        [ExpectedException(typeof(SpeedException))]
        public void ValidateSpeedTest_Invalid_TooLow()
        {
            int speed = 0;
            if (speed < Regs.minSpeed || speed > Regs.maxSpeed)
            {
                throw new SpeedException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SpeedException))]
        public void ValidateSpeedTest_Invalid_TooHigh()
        {
            int speed = 7000;
            if (speed < Regs.minSpeed || speed > Regs.maxSpeed)
            {
                throw new SpeedException();
            }
        }
    }
}
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestExample.Controllers;

namespace UnitTestExample.UnitTestExample
{
   public class AccountControllerRegister
    {
        [Test,
        TestCase("abcdABCD", false),
        TestCase("ABCD1234", false),
        TestCase("abcd1234", false),
        TestCase("abcd123", false),
        TestCase("abCD1234", true),]
        public void TestValidateRegister(string password, bool expectedResult)
        {

            var accountController = new AccountController();
            var actualResult = accountController.ValidatePassword(password);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

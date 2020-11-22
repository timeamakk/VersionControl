﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestExample.Controllers;

namespace UnitTestExample
{
    public class AccountControllerTestFixture
    {

        [Test,
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true)
            ]
        public void TestValidateEmail(string email, bool expectedResult) {

            var accountController = new AccountController();

            var actualResult = accountController.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }


}

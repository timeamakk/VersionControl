﻿using NUnit.Framework;
using System;
using System.Activities;
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





       [Test,
       TestCase("abcdABCD", false),
       TestCase("Ab1234", false),
       TestCase("abcd1234", false),
       TestCase("ABCD123", false),
       TestCase("Abcd1234", true),]
        public void TestValidatePassword(string password, bool expectedResult2)
        {

            var accountController2 = new AccountController();
            var actualResult2 = accountController2.ValidatePassword(password);

            Assert.AreEqual(expectedResult2, actualResult2);

        }

          
        
        
        
        [Test,
        TestCase("irf@uni-corvinus.hu", "Abcd1234"),
        TestCase("irf@uni-corvinus.hu", "Abcd1234567"),]
        public void TestRegisterHappyPath(string email, string password)
        {

            var accountController = new AccountController();


            var actualResult = accountController.Register(email, password);


            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }

        [Test,
        TestCase("irf@uni-corvinus", "Abcd1234"),
        TestCase("irf.uni-corvinus.hu", "Abcd1234"),
        TestCase("irf@uni-corvinus.hu", "abcd1234"),
        TestCase("irf@uni-corvinus.hu", "ABCD1234"),
        TestCase("irf@uni-corvinus.hu", "abcdABCD"),
        TestCase("irf@uni-corvinus.hu", "Ab1234"),
            ]

        public void TestRegisterValidateException(string email, string password)
        {

            var accountController = new AccountController();


            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }


        }









    }


}

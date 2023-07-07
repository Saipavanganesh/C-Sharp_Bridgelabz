using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reg_Exp;
using System;
using System.Security.Cryptography.X509Certificates;

namespace RegExpTesting
{
    [TestClass]
    public class RegexTesting
    {
        [TestMethod]
        public void InputNamePatternTest()
        {
            Program program = new Program();
            string namePattern = "^( ?[a-zA-z]{3,})*$";
            var result = program.CheckPattern("Ganesh", namePattern);
            string expected = "Valid";
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InputEmailPatternTest()
        {
            Program program = new Program();
            //string emailPattern = "^[A-Za-z0-9]+[@]+[a-z]+[.com]";
            string emailPattern = "^[a-zA-Z0-9]{3,15}@[a-zA-Z]{3,10}.(com|org)$";
            var result = program.CheckPattern("saipavan12@gmail.com", emailPattern);
            string expected = "Valid";
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InputPhoneNumberPatternTest()
        {
            Program program = new Program();
            string phoneNumberPattern = "^[6-9]{1}[0-9]{9}";
            var result = program.CheckPattern("9876543210", phoneNumberPattern);
            string expected = "Valid";
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InputPasswordPatternTest()
        {
            Program program = new Program();
            string passwordPattern = "^[a-zA-Z0-9!@#$%^&*.,]{8,}";
            //string passwordPattern = "^[A-Z]{1}[!@#$%^&*]{1}[0-9]{1}[a-z]{1}[a-zA-Z0-9]{1,4}$";
            var result = program.CheckPattern("Ganesh123", passwordPattern);
            string expected = "Valid";
            Assert.AreEqual(expected, result);
        }
    }
}

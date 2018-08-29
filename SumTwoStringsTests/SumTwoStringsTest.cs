using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumTwoStrings;
using System;

namespace SumTwoStringsTests
{
    [TestClass]
    public class SumTwoStringsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculator_WhenArgumentsIsNonNumeric_ShouldThrowArgumentException()
        {
            var arg1 = "323hfg";
            var arg2 = "fffs323hfg";

            var calc = new Calculator();
            calc.SumTwoStrings(arg1, arg2);
        }

        [TestMethod]
        public void Calculator_WhenFirstArgumentNull_ShouldReturnSecondArgument()
        {
            string arg1 = null;
            string arg2 = "354548454446547456478658467685674867";

            var calc = new Calculator();
            var result = calc.SumTwoStrings(arg1, arg2);

            Assert.AreEqual(arg2, result);
        }

        [TestMethod]
        public void Calculator_WhenSecondArgumentNull_ShouldReturnFirstArgument()
        {
            string arg1 = "354548454446547456478658467685674867";
            string arg2 = null;

            var calc = new Calculator();
            var result = calc.SumTwoStrings(arg1, arg2);

            Assert.AreEqual(arg1, result);
        }

        [TestMethod]
        public void Calculator_WhenArgumentsValid_ShouldReturnValidResult()
        {
            string arg1 = "12345678901234567890";
            string arg2 = "23232323232323232324";
            string expected = "35578002133557800214";

            var calc = new Calculator();
            var result = calc.SumTwoStrings(arg1, arg2);

            Assert.AreEqual(expected, result);
        }
    }
}

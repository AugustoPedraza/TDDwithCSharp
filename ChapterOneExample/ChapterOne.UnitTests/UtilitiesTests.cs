using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChapterOneExample.Utilities;

namespace ChapterOneExample.UnitTests
{
    public class UtilitiesTests
    {
        [Test]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();

            var actualResult =
                classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();

            var actualResult =
                classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SearchShouldBeCaseSensitive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();

            var actualResult =
                classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

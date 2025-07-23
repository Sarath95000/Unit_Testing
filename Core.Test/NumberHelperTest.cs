using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Test
{
    [TestClass]
    public class NumberHelperTest
    {
        NumberHelper numberHelper;

        //Arrange
        [TestInitialize]
        public void Setup()
        {
            numberHelper = new NumberHelper();
        }
        [TestCleanup]
        public void Cleanup()
        {
            numberHelper = null;
        }

        [TestMethod]
        [DataRow(2,true)]
        [DataRow(3,false)]
        [DataRow(4,true)]
        [DataRow(5,false)]
        [DataRow(6,true)]
        public void IsEvenNumber(int number, bool ExpectedResult)
        {
            //Act
            var ActualResult = numberHelper.IsEven(number);
            
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        [Ignore("Testcase Under Development")]
        public void IsOddNumber(int number, bool ExpectedResult) 
        {
            Assert.Fail("Yet to Develop");
        }
    }
}

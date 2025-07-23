using Core.Domain;

namespace Core.Test;

[TestClass]
public class CalculatorTest
{
    private Calculator calculator;


    [TestInitialize]
    public void Initialize()
    {
        //Arrange
        calculator = new Calculator();
    }

    [TestCleanup]
    public void TestClean()
    {
        calculator = null;
    }

    [TestMethod]
    public void AddTwoNumber_ReturnsSumAreEqual()
    {
        // Arrange
        var calculator = new Calculator();
        //Act
        var result = calculator.Add(3, 5);

            //Assert
        Assert.AreEqual(result, 8);

    }

    [TestMethod]
    public void AddTwoNumber_ReturnsSumNotEqual()
    {
        //Arrange
        var calculator = new Calculator();
        //Act
        var result = calculator.Add(3, 5);
        //Assert
        Assert.AreNotEqual(result, 3);
    }

    [TestMethod]
    [DataRow(3, 2, 5)]
    [DataRow(3, 5, 8)]
    [DataRow(5, 5, 10)]
    [DataRow(20, 22, 42)]
    [DataRow(30, 20, 50)]
    public void AddTwoNumber_ReturnsSumCheckEqual(int number1, int number2, int ExpectedResult)
    {      

        //Act
        var ActualResult = calculator.Add(number1, number2);

        //Asset
        Assert.AreEqual(ExpectedResult, ActualResult);
    }
}


public interface ICalculator
{
    int Sum(int a, int b);    
}

public class Calculator : ICalculator
{
    public int Sum(int a, int b) => a + b;
}

public class CalculatorTest
{
    [theory]
    [InlineData(2, 5, 5)]
    public void Sum_Numbers_ReturnSum(){
        //Arrange
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator
        .Setup(o => o.Sum(firstNumber, secondNumber))
        .Returns(resultExpected);

        //Act
        var result = mockCalculator.Object.Sum(firstNumber, secondNumber);

        //Assert
        Assert.Egual(result,resultExpected);
    }
}
public class CalculatorTest : IDisposable
{
    CalculatorTest _calculator;
    public CalculatorTest(){
        _calculator = new Calculator();
    }
    [Fact]
    public void Sum_Numbers_ReturnSumNUmbers(){
        //Arrange
        var calculator = new Calculator();
        var firstNumber = 2;
        var secondNumber = 3;

        //Act
        var result = calculator.Sum(firstNumber, secondNumber);

        //Assert
        Assert.Equal(result, 5);
    }
    public void Dispose(){
        _calculator = null;
    }

}
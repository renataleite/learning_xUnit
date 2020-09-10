[theory]
[InlineData(1,1,2)]
[InlineData(2,2,4)]
public void Sum_Numbers_ReturnSum(int firstNumber, int secondNumbers, int expectedResult){
    //Arrange
    //Act
    var result = _calculator.sum(firstNumber, secondNumber);
    //Assert
    Assert.Egual(result, expectedResult);
}
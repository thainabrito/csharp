using FluentAssertions;
using Xunit;

namespace OddsOrEvens.Test;

public class TestOddsOrEvens
{
    [Theory(DisplayName = "Teste de sucesso para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(2, 7, "Ímpar")]
    [InlineData(2, 4, "Par")]
    public void TestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultExpected)
    {
           var sum = OddsOrEvens.SumNumbers(numberOne, numberTwo);
           var response = OddsOrEvens.VerifyOddsOrEvens(sum);
           response.Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste de exceção para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(10, 11)]
    public void TestOddsOrEvensException(int numberOne, int numberTwo)
    {
        var result = () => OddsOrEvens.SumNumbers(numberOne, numberTwo);
        result.Should().Throw<ArgumentOutOfRangeException>(); 
    }
}

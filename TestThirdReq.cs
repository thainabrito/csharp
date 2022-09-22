using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve receber a executar o fluxo completo do programa")]
    [InlineData(new object[] {new string[]{"10"}, 10})]
    public void TestFullFlow(string[] entrys, int mockValue)
    {
    var classGuessNumber = new GuessNumber();

    var stringWriter = new StringWriter();

    var stringReader = new StringReader(string.Join("\n", entrys));

    Console.SetOut(stringWriter);
    Console.SetIn(stringReader);

    classGuessNumber.randomValue = mockValue;

    do
    {
      classGuessNumber.ChooseNumber();
      classGuessNumber.AnalyzePlay();
    } while (classGuessNumber.randomValue != classGuessNumber.userValue);

    classGuessNumber.randomValue.Should().Be(mockValue);

    classGuessNumber.userValue.Should().Be(mockValue);

    string result = stringWriter.ToString().Trim();

    result.Should().Contain("ACERTOU!");
    }
}
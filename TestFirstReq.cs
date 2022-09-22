using Xunit;
using System.IO;
using System;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory(DisplayName = "Deve exibir mensagem inicial!")]
    [InlineData(new object[] {new string[]{"---Bem-vindo ao ...---", "Para começar..."}})]
    public void TestPrintInitialMessage(string[] expected)
    {
    using var stringWriter = new StringWriter();

    Console.SetOut(stringWriter);

    var classGuessNumber = new GuessNumber();

    classGuessNumber.Greet();

    var message = stringWriter.ToString().Trim();

    foreach (var phrase in expected)
    {
      message.Should().Contain(phrase);
    }                                                  
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("0", 0)]
    [InlineData("27", 27)]
    [InlineData("20", 20)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {        
      using var stringReader = new StringReader(entry);
      Console.SetIn(stringReader);

      GuessNumber classGuessNumber = new();
      classGuessNumber.ChooseNumber();

      classGuessNumber.userValue.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        using var stringReader = new StringReader(string.Join("\n", entrys));

        using var stringWriter = new StringWriter();

        Console.SetIn(stringReader);

        Console.SetOut(stringWriter);

        var classGuessNumber = new GuessNumber();

        classGuessNumber.ChooseNumber();

        classGuessNumber.userValue.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        using var stringReader = new StringReader(string.Join("\n", entrys));

        using var stringWriter = new StringWriter();

        Console.SetIn(stringReader);

        Console.SetOut(stringWriter);

        var classGuessNumber = new GuessNumber();

        classGuessNumber.ChooseNumber();

        classGuessNumber.userValue.Should().Be(expected);
    }    
}
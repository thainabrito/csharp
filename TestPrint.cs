using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory(DisplayName = "Testa com 5 entradas diferentes se passado uma string para a função ela consegue printar a mesma string corretamente no Console")]
    [InlineData("Trybe", "Trybe")]
    [InlineData("XP", "XP")]
    [InlineData("Acelereção", "Aceleração")]
    [InlineData("C#", "C#")]
    [InlineData("testes", "testes")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);
            Message.PrintMsg(Send);
            string result = NewOutput.ToString().Trim();
            result.Should().Be(Expected);      
        }
    }
}
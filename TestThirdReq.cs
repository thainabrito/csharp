using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve imprimir o resultado")]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 1, 2)]
    public void TestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        var ballotBox = new BallotBox();
        using(var stringWriter = new StringWriter()) 
        {   

            using(var StringReader = new StringReader(string.Join("\n", entrys))) 
            {
            Console.SetOut(stringWriter);
            Console.SetIn(StringReader);
            Program.Main();
            var response = stringWriter.ToString().Trim().Split("\n");
            response.Should().Contain("A opção 1 recebeu: " + expectedReceivedOption1 + " voto(s)");
            response.Should().Contain("A opção 2 recebeu: " + expectedReceivedOption2 + " voto(s)");
            response.Should().Contain("A opção 3 recebeu: " + expectedReceivedOption3 + " voto(s)");
            response.Should().Contain("Total de votos anulados: " + expectedOptionNull + " voto(s)");       

            }

        }
    }
}
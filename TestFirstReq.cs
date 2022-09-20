using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory]
    [InlineData(1)]
    public void TestGetCountVoters(int countVoters)
    {
      BallotBox instance = new();
      var stringReader = new StringReader("1".ToString());
      Console.SetIn(stringReader);

      var response = instance.GetCountVoters();
      response.Should().Be(countVoters);
    }
}

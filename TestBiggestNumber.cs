using Xunit;
using FluentAssertions;
using System;

namespace BiggestNumber.Test;

public class TestBiggestNumber
{
    [Theory(DisplayName = "Verifica qual o maior número")]
    [InlineData(0, 0, 0, 0)]
    [InlineData(7, 8, 9, 9)]
    public void TestIdentifyBiggestNumberSucess(int first, int second, int third, int expectedNumber)
    {
    var big = BiggestNumber.IdentifyBiggestNumber(first, second, third);

      big.Should().Be(expectedNumber);
    }
}
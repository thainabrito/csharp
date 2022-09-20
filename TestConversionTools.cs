using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement{
    [Theory]
    [InlineData("1", 1)]
    public void TestConvertStrToInt(string entry, int expected)
    {
        var instance = new ConversionTools();
        instance.ConvertStrToInt(entry);

        instance.strVariable.Should().Be(entry);
        var strTypeCheck = instance.strVariable is string;
        strTypeCheck.Should().Be(true);


        instance.intVariable.Should().Be(expected);
        var intTypeCheck = instance.intVariable is int;
        intTypeCheck.Should().Be(true);
    }
}

public class TestSecondRequirement{
    [Theory]
    [InlineData("1.0", 1.0)]
    public void TestConvertStrToDouble(string entry, double expected)
    {
        var instance = new ConversionTools();
        instance.ConvertStrToDouble(entry);

        instance.strVariable.Should().Be(entry);
        var strTypeCheck = instance.strVariable is string;
        strTypeCheck.Should().Be(true);


        instance.doubleVariable.Should().Be(expected);
        var doubleTypeCheck = instance.doubleVariable is double;
        doubleTypeCheck.Should().Be(true);

    }
}

public class TestThirdRequirement{
    [Theory]
    [InlineData(1, "1")]
    public void TestConvertIntToStr(int entry, string expected)
    {
        var instance = new ConversionTools();
        instance.ConvertIntToStr(entry);

        instance.intVariable.Should().Be(entry);
        var intTypeCheck = instance.intVariable is int;
        intTypeCheck.Should().Be(true);

        instance.strVariable.Should().Be(expected);
        var strTypeCheck = instance.strVariable is string;
        strTypeCheck.Should().Be(true);
    }
}

public class TestFourthRequirement{
    [Theory]
    [InlineData(4.1, "4.1")]
    public void TestConvertDoubleToStr(double entry, string expected)
    {
        var instance = new ConversionTools();
        instance.ConvertDoubleToStr(entry);

        instance.doubleVariable.Should().Be(entry);
        var doubleTypeCheck = instance.doubleVariable is double;
        doubleTypeCheck.Should().Be(true);


        instance.strVariable.Should().Be(expected);
        var strTypeCheck = instance.strVariable is string;
        strTypeCheck.Should().Be(true);
    }
}

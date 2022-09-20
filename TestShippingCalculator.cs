using Xunit;
using FluentAssertions;
using System;

namespace ShippingCalculator.Test
{
    public class TestShippingCalculator
    {
        [Theory]
        [InlineData(43, 25)]
        public void TestCalculateShippingSuccess(double orderPrice, int resultExpected)
        {
          var instance = new ShippingCalculator();
          instance.CalculateShipping(orderPrice).Should().Be(resultExpected);
        }

        [Theory]
        [InlineData(2)]
        public void TestCalculateShippingException(double orderPrice)
        {
          var instance = new ShippingCalculator();
          Action act = () => instance.CalculateShipping(orderPrice);
          act.Should().Throw<Exception>();
        }
    }
}

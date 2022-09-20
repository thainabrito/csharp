using FluentAssertions;
using Xunit;

namespace CharacterCounter.Test;

public class TestCharacterCounter
{    

        [Theory]
        [InlineData("", 1)]
        [InlineData(" ", 1)]
        [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe", 49)]
        public void TestCharacterCounterSuccess(string text, int resultExpected)
        {
           var charactr = new CharacterCounter();
           var response = charactr.Action(text);

           response.Should().Be(resultExpected);  
        }

        [Theory]
        [InlineData(null)]
        public void TestCharacterCounterException(string text)
        {
           var stringerWriter = new StringWriter();
           Console.SetOut(stringerWriter);

           var charactrCounter = new CharacterCounter();
           Action act = () => charactrCounter.Action(text);

           act.Should().Throw<ArgumentNullException>().WithParameterName("Valor de texto inválido");  
        }
}
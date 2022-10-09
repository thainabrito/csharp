using Xunit;
using FluentAssertions;
using System;
using System.Globalization;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Title", "2022-09-24", "Description")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
        var @event = new Event(title, date, description);
        @event.Title.Should().Be(title);
        @event.EventDate.Should().Be(DateTime.Parse(date, CultureInfo.InvariantCulture));
        @event.Description.Should().Be(description);
    }

    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Title", "2022-09-24")]
    public void TestEventHalfConstructor(string title, string date)
    {
        var @event = new Event(title, date);
        @event.Title.Should().Be(title);
        @event.EventDate.Should().Be(DateTime.Parse(date, CultureInfo.InvariantCulture));
    }

    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Title", "2022-09-24", 10, "2022-10-04")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        var @event = new Event(title, date);
        @event.DelayDate(days);
        @event.EventDate.Should().Be(DateTime.Parse(expected, CultureInfo.InvariantCulture));
    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData("Title", "2022-09-24", "Description", "normal", "Evento = Title\nDate = 09/24/2022\n")]
    [InlineData("Title", "2022-09-24", "Description", "detailed", "Evento = Title\nDate = 09/24/2022\nDescription = Description")]
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        var @event = new Event(title, date, description);
        @event.PrintEvent(format).Should().Be(expected);
    }
}

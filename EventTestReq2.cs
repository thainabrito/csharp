using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("Title", "2022-09-24", "Description", 0)]
    public void TestListSearchByTitle(string title, string date, string description, int expected)
    {
        var @event = new Event(title, date, description);
        var eventList = new EventList();

        eventList.Add(@event);

        eventList.SearchByTitle(title).Should().Be(expected);
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("Title", "2022-09-24", "Description", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        var @event = new Event(title, date, description);
        var eventList = new EventList();

        eventList.Add(@event);

        eventList.SearchByDate(date).Should().Be(expected);
    }
}
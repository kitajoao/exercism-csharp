// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

public class ResistorColorTest
{
    [Fact]
    public void Black()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    [Fact]
    public void White()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    [Fact]
    public void Orange()
    {
        Assert.Equal(3, ResistorColor.ColorCode("orange"));
    }

    [Fact]
    public void Colors()
    {
        Assert.Equal(new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" }, ResistorColor.Colors());
    }
    
    [Fact]
    public void Empty()
    {
        Assert.Equal(-1, ResistorColor.ColorCode(""));
    }
    
    [Fact]
    public void Null()
    {
        Assert.Equal(-1, ResistorColor.ColorCode(null));
    }
    
    [Fact]
    public void Whitespaces()
    {
        Assert.Equal(-1, ResistorColor.ColorCode("  "));
    }
    
    [Fact]
    public void OrangeUpperCase()
    {
        Assert.Equal(3, ResistorColor.ColorCode("ORANGE"));
    }
    
    [Fact]
    public void BlackIndex()
    {
        Assert.Equal("black", ResistorColor.ColorCode(0));
    }
}
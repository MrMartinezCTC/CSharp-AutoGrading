using Xunit;

namespace ClassroomTemplate.Tests;

public class AdderTests
{
    [Theory]
    [InlineData(0, 5, 5)]
    [InlineData(2, 3, 5)]
    [InlineData(5, 0, 5)]
    [Trait("TestGroup", "Adder")]
    public void Adder_Sum_GivesSumOfParameters(int first, int second, int expected)
    {        
        Assert.Equal(expected, Adder.Sum(first, second));
    }
}

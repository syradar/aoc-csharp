using aoc_csharp;
using aoc_csharp_utils;
using Xunit;

namespace aoc_csharp_test;

public class Day1Test
{
    private const string TestInput = "Day1ATest";

    [Fact]
    public void Day1ATest()
    {
        const int expected = 7;

        Day1A problem = new(Utils.GetProblemInputs(TestInput));
        var result = problem.Solve();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Day1BTest()
    {
        const int expected = 5;

        Day1B problem = new(Utils.GetProblemInputs(TestInput));
        var result = problem.Solve();

        Assert.Equal(expected, result);
    }
}
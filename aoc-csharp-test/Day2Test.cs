using aoc_csharp;
using aoc_csharp_utils;
using Xunit;

namespace aoc_csharp_test;

public class Day2Test
{
    private const string TestInput = "Day2ATest";

    [Fact]
    public void Day2ATest()
    {
        const int expected = 150;

        Day2A problem = new(Utils.GetProblemInputStrings(TestInput));
        var result = problem.Solve();

        Assert.Equal(expected, result);
    }

    // [Fact]
    // public void Day2BTest()
    // {
    //     const int expected = 5;
    //
    //     Day2B problem = new(Utils.GetProblemInputs(TestInput));
    //     var result = problem.Solve();
    //
    //     Assert.Equal(expected, result);
    // }
}
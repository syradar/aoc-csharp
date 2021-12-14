
namespace aoc_csharp_utils;

public static class Utils
{
    public static IEnumerable<int> GetProblemInputs(string fileName)
    {
        return File.ReadLines($"{fileName}.txt").Select(int.Parse);
    }
    public static IEnumerable<string> GetProblemInputStrings(string fileName)
    {
        return File.ReadLines($"{fileName}.txt");
    }
}
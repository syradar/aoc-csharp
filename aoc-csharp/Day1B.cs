namespace aoc_csharp;

public class Day1B
{
    private readonly IEnumerable<int> _inputs;

    public Day1B(IEnumerable<int> inputs)
    {
        _inputs = inputs;
    }

    public int Solve()
    {

        var sums = _inputs.ToList()
            .Zip(_inputs.ToList().Skip(1), _inputs.ToList().Skip(2))
            .Select(cur => cur.First + cur.Second + cur.Third);

        return sums.ToList()
            .Zip(sums.ToList().Skip(1))
            .Select(ss => ss.First < ss.Second ? 1 : 0)
            .Sum();
    }
}
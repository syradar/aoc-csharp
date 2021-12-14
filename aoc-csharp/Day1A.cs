namespace aoc_csharp;

public class Day1A
{
    private readonly IEnumerable<int> _inputs;

    public Day1A(IEnumerable<int> inputs)
    {
        _inputs = inputs;
    }

    public int Solve()
    {
        return _inputs.Aggregate(new ReducingObject {Last = 0, Increases = 0}, (acc, cur) =>
        {
            if (acc.Last == 0) return new ReducingObject {Last = cur, Increases = 0};

            var increases = acc.Increases + (cur > acc.Last ? 1 : 0);

            return new ReducingObject {Last = cur, Increases = increases};
        }).Increases;
    }

    private record ReducingObject
    {
        public int Increases;
        public int Last;
    }
}
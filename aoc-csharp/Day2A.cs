namespace aoc_csharp;

public record Instruction
{
    public string Direction;
    public int Size;
}

public class Day2A
{
    private readonly List<Instruction> _inputs;

    public Day2A(IEnumerable<string> inputs)
    {
        _inputs = inputs.Select(i =>
        {
            var splat = i.Split(" ");
            
            return new Instruction()
            {
                Direction = splat[0],
                Size = int.Parse(splat[1])
            };
        }).ToList();
    }

    public int Solve()
    {
        var forwards = _inputs.Where(i => i.Direction == "forward").Sum(f => f.Size);
        var downs = _inputs.Where(i => i.Direction == "down").Sum(d => d.Size);
        var ups = _inputs.Where(i => i.Direction == "up").Sum(u => u.Size);

        var horizontal = forwards;
        var vertical = downs - ups;

        return horizontal * vertical;

    }
}
namespace AdventOfCode2022.Tests;

public class Day1Tests
{
    private readonly ITestOutputHelper _output;

    public Day1Tests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Challenge1()
    {
        _output.WriteLine(Day1.SolveChallenge1().ToString());
    }

    [Fact]
    public void Challenge2()
    {
        _output.WriteLine(Day1.SolveChallenge2().ToString());
    }
}
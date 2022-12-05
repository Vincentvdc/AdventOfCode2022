namespace AdventOfCode2022.Tests.Solutions;
public class Day4Tests
{
    private readonly ITestOutputHelper _output;

    public Day4Tests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Challenge1()
    {
        string input = "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
        Day4 day = new(input);

        Assert.Equal(2, day.Challenge1());

        day = new(Inputs.Day4);
        _output.WriteLine(day.Challenge1().ToString());
    }

    [Fact]
    public void Challenge2()
    {
        string input = "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
        Day4 day = new(input);

        Assert.Equal(4, day.Challenge2());

        day = new(Inputs.Day4);
        _output.WriteLine(day.Challenge2().ToString());
    }
}

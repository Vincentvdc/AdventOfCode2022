namespace AdventOfCode2022.Tests.Solutions;
public class Day3Tests
{
    private readonly ITestOutputHelper _output;

    public Day3Tests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Challenge1()
    {
        string input = "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw";
        Day3 day = new(input);

        Assert.Equal(157, day.Challenge1());

        day = new(Inputs.Day3);

        _output.WriteLine(day.Challenge1().ToString());
    }

    [Fact]
    public void Challenge3()
    {
        string input = "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw";
        Day3 day = new(input);

        Assert.Equal(70, day.Challenge2());

        day = new(Inputs.Day3);

        _output.WriteLine(day.Challenge2().ToString());
    }
}

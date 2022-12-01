namespace AdventOfCode2022.Solutions;

/// <summary>
/// Solution to the first day of Advent of code 2022
/// </summary>
public static class Day1
{
    public static int SolveChallenge1()
    {
        return ParseInput().First();
    }

    public static int SolveChallenge2()
    {
        return ParseInput().Sum();
    }

    private static IEnumerable<int> ParseInput()
    {
        return Inputs.Day1.Split("\r\n\r\n") // Splits per elf
                          .Select(elf => elf.Split("\r\n") // Splits individual calories for every elf
                          .Select(calories => Convert.ToInt32(calories)))
                          .Select(calories => calories.Sum())
                          .OrderByDescending(calories => calories)
                          .Take(3); // We only care about the top 3 records for these challenges
    }
}
namespace AdventOfCode2022.Solutions;
public class Day4 : DayBase<int>
{
    public Day4(string input) : base(input)
    {
    }

    public override int Challenge1()
    {
        var pairs = ParseInputs();
        return pairs.Count(CheckIfAssignmentsFullyOverlap);
    }

    public override int Challenge2()
    {
        var pairs = ParseInputs();
        return pairs.Count(CheckIfAssignmentsOverlap);
    }
    public static bool CheckIfAssignmentsFullyOverlap((IEnumerable<int> assignment1, IEnumerable<int> assignment2) pair)
    {
        int intersecting = pair.assignment1.Intersect(pair.assignment2).Count();
        return intersecting == pair.assignment1.Count() || intersecting == pair.assignment2.Count();
    }

    public static bool CheckIfAssignmentsOverlap((IEnumerable<int> assignment1, IEnumerable<int> assignment2) pair)
    {
        int intersecting = pair.assignment1.Intersect(pair.assignment2).Count();
        return intersecting > 0;
    }

    private IEnumerable<(IEnumerable<int> assignment1, IEnumerable<int> assignment2)> ParseInputs()
    {
        IEnumerable<(string assignment1, string assignment2)> parsedLines = _input.Split("\r\n").Select(pair => pair.Split(',')).Select(pair => (pair[0], pair[1]));

        return parsedLines.Select(pair => (ExtractRange(pair.assignment1), ExtractRange(pair.assignment2)));

    }

    private static IEnumerable<int> ExtractRange(string assignment)
    {
        string[] range = assignment.Split('-');
        int start = Convert.ToInt32(range[0]);
        int end = Convert.ToInt32(range[1]);
        int count = end - start + 1;
        return Enumerable.Range(start, count);

    }

}

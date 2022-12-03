namespace AdventOfCode2022.Solutions;
public class Day3 : DayBase<int>
{
    public Day3(string input) : base(input)
    {
    }

    public override int Challenge1()
    {
        var rucksacks = ParseInput();
        var duplicateItems = rucksacks.Select(rucksack => rucksack.Compartment1.Intersect(rucksack.Compartment2).Single());
        return duplicateItems.Select(CalculatePriority).Sum();
    }
    public override int Challenge2()
    {
        var rucksacks = ParseInput().ToArray();

        const int groupSize = 3;

        List<char> badges = new();
        for (int i = 0; i < rucksacks.Length; i += groupSize)
        {
            var sack1 = rucksacks[i];
            var sack2 = rucksacks[i + 1];
            var sack3 = rucksacks[i + 2];
            badges.Add(sack1.Contents.Intersect(sack2.Contents).Intersect(sack3.Contents).Single());
        }

        return badges.Select(CalculatePriority).Sum();
    }

    private IEnumerable<Rucksack> ParseInput()
    {
        return _input.Split("\r\n").Select(rucksack => new Rucksack(rucksack));
    }

    private static int CalculatePriority(char item)
    {
        int offset = char.IsUpper(item) ? -38 : -96;
        return item + offset;
    }
}
internal readonly struct Rucksack
{
    public readonly string Contents;
    public readonly string Compartment1;
    public readonly string Compartment2;

    public Rucksack(string contents)
    {
        Contents = contents;
        Compartment1 = Contents[..(Contents.Length / 2)];
        Compartment2 = Contents[(Contents.Length / 2)..];
    }
}

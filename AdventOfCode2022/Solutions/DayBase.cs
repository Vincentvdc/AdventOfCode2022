namespace AdventOfCode2022.Solutions;
public abstract class DayBase<T>
{
    protected string _input;

    public DayBase(string input)
    {
        _input = input;
    }

    public abstract T Challenge1();
    public abstract T Challenge2();
}

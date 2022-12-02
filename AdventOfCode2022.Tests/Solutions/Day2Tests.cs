namespace AdventOfCode2022.Tests.Solutions
{
    public class Day2Tests
    {
        private readonly ITestOutputHelper _output;

        public Day2Tests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Challenge1()
        {
            string testInput = "A Y\r\nB X\r\nC Z";
            Day2 day = new(testInput);
            int result = day.SolveChallenge1();
            Assert.Equal(15, result);

            day = new(Inputs.Day2);
            _output.WriteLine(day.SolveChallenge1().ToString());
        }

        [Fact]
        public void Challenge2()
        {
            string testInput = "A Y\r\nB X\r\nC Z";
            Day2 day = new(testInput);
            int result = day.SolveChallenge2();
            Assert.Equal(12, result);

            day = new(Inputs.Day2);
            _output.WriteLine(day.SolveChallenge2().ToString());
        }

    }
}

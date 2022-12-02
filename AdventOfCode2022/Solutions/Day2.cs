namespace AdventOfCode2022.Solutions;
public class Day2
{
    private readonly string _input;

    public Day2(string input)
    {
        _input = input;
    }


    public int SolveChallenge1()
    {
        var games = ParseInput();

        return games.Select(game => Move.GetMove(game.player).PlayGame(game.opponent)).Sum();
    }

    public int SolveChallenge2()
    {
        var games = ParseInput();

        return games.Select(game => Move.GetMove(game.opponent).PlayGameWithResult(game.player)).Sum();
    }

    private IEnumerable<(char opponent, char player)> ParseInput()
    {
        return _input.Split("\r\n").Select(input => (input[0], input[2]));
    }

    private class Move
    {
        // A = rock, B = paper, C = scissors
        // X = rock, Y = paper, Z = scissors
        public static readonly IReadOnlyCollection<Move> Moves = new Move[]
        {
            new(input: 'X', losesFrom: 'B', winsFrom: 'C', scoreForPlay: 1),
            new(input: 'Y', losesFrom: 'C', winsFrom: 'A', scoreForPlay: 2),
            new(input: 'Z', losesFrom: 'A', winsFrom: 'B', scoreForPlay: 3),

            new(input: 'A', losesFrom: 'Y', winsFrom: 'Z', scoreForPlay: 1),
            new(input: 'B', losesFrom: 'Z', winsFrom: 'X', scoreForPlay: 2),
            new(input: 'C', losesFrom: 'X', winsFrom: 'Y', scoreForPlay: 3),

        };

        public static IReadOnlyDictionary<char, GameResult> ResultDictionary = new Dictionary<char, GameResult>()
        {
            {'X', GameResult.Loss },
            {'Y', GameResult.Draw },
            {'Z', GameResult.Win }
        };

        public readonly char Input;
        public readonly char LosesFrom;
        public readonly char WinsFrom;
        public readonly int ScoreForPlay;

        private Move(char input, char losesFrom, char winsFrom, int scoreForPlay)
        {
            Input = input;
            LosesFrom = losesFrom;
            WinsFrom = winsFrom;
            ScoreForPlay = scoreForPlay;
        }

        public static Move GetMove(char input)
        {
            return Moves.Single(move => move.Input == input);
        }

        public int PlayGame(char opponentInput)
        {
            if (opponentInput == WinsFrom)
                return CalculateScore(GameResult.Win);
            else if (opponentInput != LosesFrom)
                return CalculateScore(GameResult.Draw);
            return CalculateScore(GameResult.Loss);
        }

        public int PlayGameWithResult(char result)
        {
            var outcome = ResultDictionary[result];
            Move playermove = outcome switch
            {
                GameResult.Win => GetMove(LosesFrom),
                GameResult.Draw => GetMove(Input),
                GameResult.Loss => GetMove(WinsFrom),
                _ => throw new NotImplementedException()
            };
            return playermove.PlayGame(Input);
        }

        public int CalculateScore(GameResult result)
        {
            return ScoreForPlay + ((int)result);
        }

        public enum GameResult
        {
            Win = 6,
            Draw = 3,
            Loss = 0
        }
    }
}

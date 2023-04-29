using RockSissorsPaper;

namespace RockSissorsPaperTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(RSP.Paper, RSP.Rock, Result.Winner1)]
        [InlineData(RSP.Paper, RSP.Paper, Result.Draw)]
        [InlineData(RSP.Paper, RSP.Scissors, Result.Winner2)]
        [InlineData(RSP.Rock, RSP.Rock, Result.Draw)]
        [InlineData(RSP.Rock, RSP.Paper, Result.Winner2)]
        [InlineData(RSP.Rock, RSP.Scissors, Result.Winner1)]
        [InlineData(RSP.Scissors, RSP.Rock, Result.Winner2)]
        [InlineData(RSP.Scissors, RSP.Paper, Result.Winner1)]
        [InlineData(RSP.Scissors, RSP.Scissors, Result.Draw)]
        public void Test1(RSP p1, RSP p2, Result winner)
        {
            WinnerChecker checker = new WinnerChecker();
            var result = checker.Fight((int)p1, (int)p2);
            Assert.Equal(winner, result);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test2(bool isClassicGame)
        {
            var checker = WinCheckerFabric.Create(isClassicGame);
            Assert.Throws<ArgumentException>(() => checker.Fight(10, 10));
        }

        [Theory]
        [InlineData(RSPLS.Lizard, RSPLS.Lizard, Result.Draw)]
        [InlineData(RSPLS.Lizard, RSPLS.Paper, Result.Winner1)]
        [InlineData(RSPLS.Lizard, RSPLS.Rock, Result.Winner2)]
        [InlineData(RSPLS.Lizard, RSPLS.Scissors, Result.Winner2)]
        [InlineData(RSPLS.Lizard, RSPLS.Spock, Result.Winner1)]
        [InlineData(RSPLS.Paper, RSPLS.Lizard, Result.Winner2)]
        [InlineData(RSPLS.Paper, RSPLS.Paper, Result.Draw)]
        [InlineData(RSPLS.Paper, RSPLS.Rock, Result.Winner1)]
        [InlineData(RSPLS.Paper, RSPLS.Scissors, Result.Winner2)]
        [InlineData(RSPLS.Paper, RSPLS.Spock, Result.Winner1)]
        [InlineData(RSPLS.Rock, RSPLS.Lizard, Result.Winner1)]
        [InlineData(RSPLS.Rock, RSPLS.Paper, Result.Winner2)]
        [InlineData(RSPLS.Rock, RSPLS.Rock, Result.Draw)]
        [InlineData(RSPLS.Rock, RSPLS.Scissors, Result.Winner1)]
        [InlineData(RSPLS.Rock, RSPLS.Spock, Result.Winner2)]
        [InlineData(RSPLS.Scissors, RSPLS.Lizard, Result.Winner1)]
        [InlineData(RSPLS.Scissors, RSPLS.Paper, Result.Winner1)]
        [InlineData(RSPLS.Scissors, RSPLS.Rock, Result.Winner2)]
        [InlineData(RSPLS.Scissors, RSPLS.Scissors, Result.Draw)]
        [InlineData(RSPLS.Scissors, RSPLS.Spock, Result.Winner2)]
        [InlineData(RSPLS.Spock, RSPLS.Lizard, Result.Winner2)]
        [InlineData(RSPLS.Spock, RSPLS.Paper, Result.Winner2)]
        [InlineData(RSPLS.Spock, RSPLS.Rock, Result.Winner1)]
        [InlineData(RSPLS.Spock, RSPLS.Scissors, Result.Winner1)]
        [InlineData(RSPLS.Spock, RSPLS.Spock, Result.Draw)]
        public void Test3(RSPLS p1, RSPLS p2, Result winner)
        {
            var checker = new WinnerCheckerModified();
            var result = checker.Fight((int)p1, (int)p2);
            Assert.Equal(winner, result);
        }
    }
}
using Testing;

namespace TestMathCalculator
{
    public class UnitTest1
    {
        private const int Five = 5;
        private const int Three = 3;

        [Fact]
        public void Test1()
        {
            MathCalculator mathCalculator = new MathCalculator();
            var result = mathCalculator.Sum(Five, Three);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Test2()
        {
            MathCalculator mathCalculator = new MathCalculator();
            var result = mathCalculator.Substract(Five, Three);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            MathCalculator mathCalculator = new MathCalculator();
            var result = mathCalculator.Sum(-Five, -Three);
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Test4()
        {
            MathCalculator mathCalculator = new MathCalculator();
            var result = mathCalculator.Substract(Five, -Three);
            Assert.Equal(8, result);
        }
    }
}
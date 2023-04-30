using System.Collections;
using Testing;

namespace TestMathCalculator
{
    public class Data : IDisposable
    {
        public MathCalculator MathCalculator { get; set; }

        public Data()
        {
            MathCalculator = new MathCalculator();
        }

        public void Dispose()
        {
            // Отчищаем данные, если надо
        }
    }

    public class UnitTest1 : IClassFixture<Data>
    {
        private const int Five = 5;
        private const int Three = 3;

        private Data _data;

        public UnitTest1(Data data)
        {
            _data = data;
        }

        [Fact(DisplayName = "Sum five and three")]
        [Trait("First sum test", "Sum")]
        public void Test1()
        {
            var result = _data.MathCalculator.Sum(Five, Three);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Test2()
        {
            var result = _data.MathCalculator.Substract(Five, Three);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            var result = _data.MathCalculator.Sum(-Five, -Three);
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Test4()
        {
            var result = _data.MathCalculator.Substract(Five, -Three);
            Assert.Equal(8, result);
        }

        [Theory(DisplayName = "Test CalculatorTestData")]
        [ClassData(typeof(CalculatorTestData))]
        public void Test5(int v1, int v2, int v3)
        {
            var result = _data.MathCalculator.Sum(v1, v2);
            Assert.Equal(v3, result);
        }
    }

    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 1, -2, -1 };
            yield return new object[] { -1, -2, -3 };
            yield return new object[] { -1, 2, 1 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
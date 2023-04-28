using FluentAssertions;
using Main.ProblemSolving.PlusMinus;

namespace MainTests.ProblemSolving
{
    public class PlusMinusSpec
    {
        [Fact]
        private void ShouldPrintSixScaleValues()
        {
            var consoleValue = new StringWriter();

            Console.SetOut(consoleValue);

            PlusMinus.PlusMinusFunction(new List<int> { 1, 2, 3, -1, -2, -3, 0, 0 });

            var consoleOutputList = consoleValue.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in consoleOutputList)
            {
                int index = item.IndexOf(',');

                string restAfterComma = item.Substring(index + 1);

                int legth = restAfterComma.Length;

                legth.Should().Be(6);
            }

        }

        [Fact]
        private void ShouldGetCorretlyValues()
        {
            var consoleValue = new StringWriter();

            Console.SetOut(consoleValue);

            PlusMinus.PlusMinusFunction(new List<int> { -4, 3, -9, 0, 4, 1 });

            var consoleOutputList = consoleValue.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();

            decimal.TryParse(consoleOutputList[0], out decimal result1);
            decimal.TryParse(consoleOutputList[1], out decimal result2);
            decimal.TryParse(consoleOutputList[2], out decimal result3);

            result1.Should().Be(0.500000m);
            result2.Should().Be(0.333333m);
            result3.Should().Be(0.166667m);
        }

        [Fact]
        private void ShouldGetMessagePassingEmptyList()
        {
            var consoleValue = new StringWriter();

            Console.SetOut(consoleValue);

            PlusMinus.PlusMinusFunction(new List<int>());

            consoleValue.ToString().Should().Be("Empty List");
        }
    }
}


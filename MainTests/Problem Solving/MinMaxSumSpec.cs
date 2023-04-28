using FluentAssertions;
using Main.ProblemSolving;
using Main.ProblemSolving.MinMaxSum;

namespace MainTests.ProblemSolving
{
    public class MinMaxSumSpec
    {
        [Theory]
        [MemberData(nameof(MinMaxSumParameters))]
        private void ShouldSumCorretly(Model model, Result result)
        {
            var consoleValue = new StringWriter();
            Console.Clear();

            Console.SetOut(consoleValue);

            MinMaxSum.MiniMaxSumFunction(model.Content ?? new List<int>());

            var consoleOutput = consoleValue.ToString();

            Assert.Equivalent(result.ExpectedResult, consoleOutput);
            Console.Clear();
        }

        public static IEnumerable<object[]> MinMaxSumParameters()
        {
            yield return new object[]
            {
                new Model
                {
                    Content = new List<int>{ 256741038, 623958417, 467905213, 714532089, 938071625 }
                },
                new Result
                {
                    ExpectedResult = "2063136757 2744467344"
                }
            };

            yield return new object[]
            {
                new Model
                {
                    Content = new List<int>{ 1, 3, 5, 7, 9 }
                },
                new Result
                {
                    ExpectedResult = "16 24"
                }
            };

            yield return new object[]
            {
                new Model
                {
                    Content = new List<int>{ 5, 5, 5, 5, 5 }
                },
                new Result
                {
                    ExpectedResult = "20 20"
                }
            };
        }
    }

    public class Model
    {
        public List<int>? Content { get; set; }
    }

    public class Result
    {
        public string? ExpectedResult { get; set; }
    }
}


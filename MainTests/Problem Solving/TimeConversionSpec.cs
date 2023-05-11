using Main.ProblemSolving.TimeConversion;

namespace MainTests.ProblemSolving
{
    public class TimeConversionSpec
    {
        [Theory]
        [MemberData(nameof(TimeConversionParameters))]
        private void ShouldConvertTime(dynamic model, dynamic expected)
        {
            var result = TimeConversion.TimeConversionFunction(model.Content ?? string.Empty);

            Assert.Equivalent(result, expected.ExpectedResult);
        }

        public static IEnumerable<object[]> TimeConversionParameters()
        {
            yield return new object[]
            {
                new
                {
                    Content = "07:05:45PM"
                },
                new
                {
                    ExpectedResult = "19:05:45"
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = "12:20:10PM"
                },
                new
                {
                    ExpectedResult = "12:20:10"
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = "12:45:22AM"
                },
                new
                {
                    ExpectedResult = "00:45:22"
                }
            };
        }
    }
}


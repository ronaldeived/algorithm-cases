using System;
using Main.ProblemSolving.Multiple;
using Main.ProblemSolving.TimeConversion;

namespace MainTests.ProblemSolving
{
    public class MultipleSpec
    {
        [Theory]
        [MemberData(nameof(MultipleParameters))]
        private void ShouldExpectMultipleCorretly(dynamic model, dynamic expected)
        {
            var result = Multiple.FizzBuzz(model.Content);

            Assert.Equivalent(result, expected.ExpectedResult);
        }

        public static IEnumerable<object[]> MultipleParameters()
        {
            yield return new object[]
            {
                new
                {
                    Content = 15
                },
                new
                {
                    ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz".TrimEnd()
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = 65
                },
                new
                {
                    ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29\nFizzBuzz\n31\n32\nFizz\n34\nBuzz\nFizz\n37\n38\nFizz\nBuzz\n41\nFizz\n43\n44\nFizzBuzz\n46\n47\nFizz\n49\nBuzz\nFizz\n52\n53\nFizz\nBuzz\n56\nFizz\n58\n59\nFizzBuzz\n61\n62\nFizz\n64\nBuzz".TrimEnd()
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = 12
                },
                new
                {
                    ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz".TrimEnd()
                }
            };
        }
    }
}


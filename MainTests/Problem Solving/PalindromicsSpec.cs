using System;
using Main.ProblemSolving.WordsPalindromics;

namespace MainTests.ProblemSolving
{
    public class PalindromicsSpec
    {
        [Theory]
        [MemberData(nameof(TestPalindromics))]
        private void ShouldExpectMultipleCorretly(dynamic model, dynamic expected)
        {
            var result = Palindromics.GetPalindromics(model.Content);

            Assert.Equivalent(result, expected.ExpectedResult);
        }

        public static IEnumerable<object[]> TestPalindromics()
        {
            yield return new object[]
            {
                new
                {
                    Content = "abssolosl"
                },
                new
                {
                    ExpectedResult = "solos"
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = "abcc"
                },
                new
                {
                    ExpectedResult = "none"
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = "abccc"
                },
                new
                {
                    ExpectedResult = "ccc"
                }
            };

            yield return new object[]
            {
                new
                {
                    Content = "kjrotatorj"
                },
                new
                {
                    ExpectedResult = "jrotatorj"
                }
            };
        }
    }
}


using System;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Main.ProblemSolving.Multiple
{
    public static class Multiple
    {
        public static string FizzBuzz(int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.AppendLine("Buzz");
                }
                else
                {
                    result.AppendLine(i.ToString());
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}


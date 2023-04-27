using System;

namespace Main.ProblemSolving
{
    public abstract class PlusMinus
    {
        public static void PlusMinusFunction(List<int> arr)
        {
            if (!arr.Any())
            {
                Console.Write("Empty List");
                return;
            }

            var total = arr.Count();
            var positive = arr.Count(x => x > 0);
            var negative = arr.Count(x => x < 0);
            var zero = arr.Count(x => x == 0);

            decimal positiveResult = decimal.Divide(positive, total);
            decimal negativeResult = decimal.Divide(negative, total);
            decimal zeroResult = decimal.Divide(zero, total);

            Console.WriteLine(positiveResult.ToString("N6"));
            Console.WriteLine(negativeResult.ToString("N6"));
            Console.WriteLine(zeroResult.ToString("N6"));
        }
    }
}


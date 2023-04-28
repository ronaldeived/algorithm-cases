using System;
using System.Linq;

namespace Main.ProblemSolving.MinMaxSum
{
    public static class MinMaxSum
    {
        public static void MiniMaxSumFunction(List<int> arr)
        {
            var minIndex = arr.IndexOf(arr.Min());
            var maxIndex = arr.IndexOf(arr.Max());

            var minimum = arr
                .Select((item, index) => index != maxIndex ? (ulong)item : 0)
                .ToList()
                .Aggregate((a, b) => a + b);

            var maximum = arr
                .Select((item, index) => index != minIndex ? (ulong)item : 0)
                .ToList()
                .Aggregate((a,b) => a + b);

            Console.Write($"{minimum} {maximum}");
        }
    }
}


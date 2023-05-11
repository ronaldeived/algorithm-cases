using System;
namespace Main.ProblemSolving.TimeConversion
{
    public static class TimeConversion
    {
        public static string TimeConversionFunction(string s)
        {
            DateTime dateTime;

            if (!DateTime.TryParse(s, out dateTime))
            {
                throw new ArgumentException("Input must be a valid time string in the format hh:mm:ssAM or hh:mm:ssPM.", nameof(s));
            }

            return dateTime.ToString("HH:mm:ss");
        }
    }
}


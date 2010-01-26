using System;

namespace BuildDay
{
    internal class Program
    {
        private static void Main()
        {
            string dayOfYear = DateTime.Now.DayOfYear.ToString("000");
            string year = DateTime.Now.ToString("yy");
            Console.WriteLine("{0}{1:000}", year, dayOfYear);
        }
    }
}
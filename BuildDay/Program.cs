//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Madhon">
//     Company (c) 2015-2020 Madhon
// </copyright>
//-----------------------------------------------------------------------

namespace BuildDay
{
    using System;

    /// <summary>
    /// Main Entry point class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main Entry point method
        /// </summary>
        public static void Main()
        {
            var dayOfYear = DateTime.Now.DayOfYear.ToString("000");
            var year = DateTime.Now.ToString("yy");
            Console.WriteLine("{0}{1:000}", year, dayOfYear);
        }
    }
}
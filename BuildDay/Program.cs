//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Madhon">
//     Company (c) 2016 Madhon
// </copyright>
//-----------------------------------------------------------------------

namespace BuildDay
{
    using System;

    /// <summary>
    /// Main Entry point class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Entry point method
        /// </summary>
        private static void Main()
        {
            string dayOfYear = DateTime.Now.DayOfYear.ToString("000");
            string year = DateTime.Now.ToString("yy");
            Console.WriteLine("{0}{1:000}", year, dayOfYear);
        }
    }
}
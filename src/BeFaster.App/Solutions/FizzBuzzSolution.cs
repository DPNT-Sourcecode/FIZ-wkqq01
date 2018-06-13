﻿using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var numberString = number.ToString();

            var results = new List<string>();

            var deluxe = new List<string>();
            if (number % 3 == 0 && numberString.Contains("3"))
            {
                results.Remove("fizz");
                deluxe.Add("fizz");
            }
            if (number % 5 == 0 && numberString.Contains("5"))
            {
                results.Remove("buzz");
                deluxe.Add("buzz");
            }

            if (deluxe.Any())
            {
                results.Add(string.Join(" ", deluxe));
                results.Add(number % 2 == 1 ? "fake deluxe" : "deluxe");
            }

            else
            {
                // FIZ_R5 - All the previous rules for "fizz" and "buzz" are still valid
                // ↑ bullshit!
                if (number % 3 == 0 || numberString.Contains("3"))
                    results.Add("fizz");
                if (number % 5 == 0 || numberString.Contains("5"))
                    results.Add("buzz");
            }

            return results.Any()
                ? string.Join(" ", results)
                : number.ToString();
        }
    }
}

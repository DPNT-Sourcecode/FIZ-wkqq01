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

            if (number % 3 == 0 || numberString.Contains("3")) results.Add("fizz");
            if (number % 5 == 0 || numberString.Contains("5")) results.Add("buzz");
            if (number > 10 && number.ToString().Distinct().Count() == 1) results.Add("deluxe");

            return results.Any()
                ? string.Join(" ", results)
                : number.ToString();
        }
    }
}

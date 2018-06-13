using System.Collections.Generic;
using System.Linq;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var results = new List<string>();
            if (number % 3 == 0) results.Add("fizz");
            if (number % 5 == 0) results.Add("buzz");

            return results.Any()
                ? string.Join(" ", results)
                : number.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var numberString = number.ToString();

            var results = new List<string>();

            bool fizz = false, buzz = false, deluxe = false, fake = false;

            if (number % 3 == 0 && numberString.Contains("3"))
                deluxe = fizz = true;
            if (number % 5 == 0 && numberString.Contains("5"))
                deluxe = buzz = true;

            if (deluxe) fake = number % 2 == 1;

            if (number % 3 == 0 || numberString.Contains("3"))
                fizz = true;
            if (number % 5 == 0 || numberString.Contains("5"))
                buzz = true;

            if (fizz) results.Add("fizz");
            if (buzz) results.Add("buzz");
            if (deluxe) results.Add(fake ? "fake deluxe" : "deluxe");

            return results.Any()
                ? string.Join(" ", results)
                : number.ToString();
        }
    }
}

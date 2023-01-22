using System;
using System.Collections.Generic;
namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
            {
                return "";
            }

            if (items.Length == 1)
            {
                return items[0];
            }

            string lastItem = items[items.Length - 1];
            string firstItem = items[0];
            string middleSection = "";

            for (int i = 1; i < items.Length - 1; i++)
            {
                middleSection += ", " + items[i];
            }

            return $"{firstItem}{middleSection} and {lastItem}";
        }
    }
}

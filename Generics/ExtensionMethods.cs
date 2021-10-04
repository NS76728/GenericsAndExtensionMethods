using System;
using System.Collections.Generic;
using System.Linq;
namespace Generics
{
    public static class ExtensionMethods
    {

        public static string pluralize(string s)
        {
            return s + "s";
        }
        public static T[] SortArray<T>(this T[] Array)
        {
            return Array.OrderBy(x => x).ToArray();
        }

    }
}

using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length == 1)
                return original;
            string result = "";
            for (var x = 1; x < original.Length - 1; x++)
                result = result + original[x];
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bodhibelly.Extensions
{
    public static class StringExtentions
    {
        public static string Truncate(this string value, int maxlength)
        {
            return Truncate(value, maxlength, "...");
        }
        public static string Truncate(this string value, int maxlength, string tail)
        {
            if(null == value) return null;
            if (value.Length < maxlength) return value;
            if(null == tail) tail = "";

            return value.Substring(0, maxlength - tail.Length) + tail;
        }
    }
}
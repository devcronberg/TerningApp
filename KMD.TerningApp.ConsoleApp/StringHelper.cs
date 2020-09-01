using System;
using System.Collections.Generic;
using System.Text;

namespace MCronberg
{
    public static class StringHelper
    {
        public static string Proper(this string t)
        {
            return t.Substring(0, 1).ToUpper() + t.Substring(1).ToLower();
        }

    }
}

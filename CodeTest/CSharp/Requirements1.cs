using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.CSharp
{
    public static class Requirements1
    {
        /// <summary>
        /// Extension method IsNullOrEmpty
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return value == null || value == string.Empty;
        }
    }
}
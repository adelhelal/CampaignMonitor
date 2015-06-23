using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.CSharp
{
    public class Requirements2
    {
        /// <summary>
        /// Iterate through each positive integer less than or equals to the provided value
        /// and return only those integers that have no remainder
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IEnumerable<int> PositiveDivisors(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0) //Only return integers without remainders
                {
                    yield return i;
                }
            }
        }
    }
}
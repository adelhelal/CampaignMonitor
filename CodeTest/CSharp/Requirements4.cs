using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.CSharp
{
    public class Requirements4
    {
        /// <summary>
        /// Group the list of numbers and 
        /// filter the numbers based on the maximum occurence
        /// </summary>
        /// <param name="values">List of arbitrary numbers</param>
        /// <returns>Filtered list of numbers used most</returns>
        public List<int> MostCommon(List<int> values)
        {
            // Group the list of numbers by the numbers themselves
            // then select the list of unique numbers with their count
            var list = values.GroupBy(l => l).Select(l => new { l.Key, Count = l.Count() });

            // then filter only the top count
            // return only list of filtered numbers
            return list.Where(l => l.Count == list.Max(m => m.Count)).Select(l => l.Key).ToList();
        }
    }
}
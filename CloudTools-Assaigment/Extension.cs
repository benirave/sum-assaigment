using System;
using System.Collections.Generic;
using System.Text;

namespace CloudTools_Assaigment
{
    public static class Extension
    {
        public static int Sum(this List<int> arrayOfNumbers)
        {
            int result = 0;
            foreach (var number in arrayOfNumbers)
            {
                result += number;
            }
            return result;
        }
    }
}

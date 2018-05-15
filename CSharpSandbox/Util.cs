using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    public static class Util
    {
        public static int ConvertToBase(this int i, int baseToConvertTo) //this keyword identifies it as an extension method, specifically it is extending the int type
        {
            var result = 0;
            var iterations = 0;

            if (baseToConvertTo < 2 || baseToConvertTo > 10)
                throw new ArgumentException("Value cannot be converted to base " + baseToConvertTo.ToString());

            do
            {
                var nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                result += nextDigit * (int) Math.Pow(10, iterations);
                iterations++;
            } while (i != 0);

            return result;
        }
    }
}
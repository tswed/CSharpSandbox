using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    public struct StructDate
    {
        private int year;
        private int month;
        private int day;

        public StructDate(int yyyy, int mm, int dd)
        {
            year = yyyy - 1900;
            month = mm;
            day = dd - 1;
        }

        public override string ToString()
        {
            return $"{month} {day + 1} {year + 1900}";
        }
    }
}

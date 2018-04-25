using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    struct StructDate
    {
        private int year;
        private int month;
        private int day;

        public StructDate(int yyyy, int mm, int dd)
        {
            this.year = yyyy - 1900;
            this.month = mm;
            this.day = dd - 1;
        }

        public override string ToString()
        {
            return $"{this.month} {this.day + 1} {this.year + 1900}";
        }
    }
}

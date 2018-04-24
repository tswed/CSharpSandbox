using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    [Flags]
    public enum FlagsEnumDays
    {
        //Used to perform bitwise operations can be performed on them.
        //Days Meetingdays = Days.Tuesday | Days.Monday;
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x3
    }
}

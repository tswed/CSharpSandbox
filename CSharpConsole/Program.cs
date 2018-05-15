using System;
using CSharpSandbox;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Seasons.Fall);

            StructDate defaultDate = new StructDate(2018, 05, 01);

            Console.WriteLine(defaultDate);

            int x = 591;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} in base {1} is {2}", x, i, x.ConvertToBase(i));  //Using extension method on the int type
            }
        }
    }
}

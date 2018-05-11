using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr10
{
    class Number
    {
        public int Method(string input)
        {
            int intResult;
            double doubleResult;
            int b;

            if (Int32.TryParse(input, out intResult))
            {
                b = 1;

            }
            else if (Double.TryParse(input, out doubleResult))
            {
                b = 2;
            }
            else
            {
                b = 0;
            }

            return b;
        }
    }
}

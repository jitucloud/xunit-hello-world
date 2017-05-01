using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit.Examples
{
    public class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}

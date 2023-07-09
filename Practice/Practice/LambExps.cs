using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LambExps
    {
        public void LambEx()
        {
            Func<int, int, int> sum = (x, y) =>
            {
                return x + y;
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public  class NumberHelper
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}

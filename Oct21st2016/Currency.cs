using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct21st2016
{
    public class Currency
    {
        private readonly long _amount;
        public Currency(long amount)
        {
            _amount = amount;
        }

        public long GetAmount()
        {
            return _amount;
        }
    }
}

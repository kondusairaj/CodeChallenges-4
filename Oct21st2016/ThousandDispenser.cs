using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct21st2016
{
    public class ThousandDispenser : IDispense
    {
        private IDispense _chain;
        private readonly int _denomination = 1000;

        public void SetNextDispenser(IDispense next)
        {
            _chain = next;
        }

        public void DispenseCash(Currency cur)
        {
            try
            {
                long amount = cur.GetAmount();
                if (amount >= _denomination)
                {
                    long num = amount / _denomination;
                    long remainder = amount % _denomination;
                    Console.WriteLine(_denomination + " * " + num);
                    if (remainder != 0) _chain.DispenseCash(new Currency(remainder));
                }
                else
                {
                    _chain.DispenseCash(cur);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0} ", ex.Message);
            }
        }
    }
}

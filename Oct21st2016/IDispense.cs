using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct21st2016
{
    public interface IDispense
    {
        void SetNextDispenser(IDispense next);

        void DispenseCash(Currency cur);
    }
}

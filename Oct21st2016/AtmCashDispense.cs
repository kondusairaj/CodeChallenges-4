using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct21st2016
{
    public class AtmCashDispense
    {
        // Used Chain of Responsibility Pattern
        private readonly IDispense _dispenser1;

        public AtmCashDispense()
        {
            this._dispenser1 = new ThousandDispenser();
            IDispense dispenser2 = new FiveHundredDispenser();
            IDispense dispenser3 = new HundredDispenser();

            _dispenser1.SetNextDispenser(dispenser2);
            dispenser2.SetNextDispenser(dispenser3);
        }

        public static void Main(String[] args)
        {
            try
            {
                AtmCashDispense atmDispenser = new AtmCashDispense();
                while (true)
                {
                    long amount = Convert.ToInt64(Console.ReadLine());
                    if (amount % 100 != 0)
                    {
                        Console.WriteLine("Amount cannot be dispensed");
                        break;
                    }
                    atmDispenser._dispenser1.DispenseCash(new Currency(amount));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0} ", ex.Message);
            }
            Console.ReadKey();
        }
    }
}

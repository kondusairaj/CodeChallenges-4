using Nov18th2016.Context;
using Nov18th2016.State;

namespace Nov18th2016.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// Closed indicates that account is in closed state
    /// </remarks>
    /// </summary>
    public class Closed : AccountState
    {
        public Closed(Account account)
        {
            this.account = account;
        }

        public override bool Deposit()
        {
            return false;
        }

        public override bool WithDraw()
        {
            return false;
        }

        public override bool BalanceEnquiry()
        {
            return false;
        }
    }
}

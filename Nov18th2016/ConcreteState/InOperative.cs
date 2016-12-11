using Nov18th2016.Context;
using Nov18th2016.State;

namespace Nov18th2016.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// InOperative indicates that account is in In-Operative state
    /// </remarks>
    /// </summary>
    public class InOperative : AccountState
    {
        public InOperative(Account account)
        {
            this.account = account;
        }

        public override bool Deposit()
        {
            account.AccountState = new Active(this);
            return true;
        }

        public override bool WithDraw()
        {
            account.AccountState = new Active(this);
            return true;
        }

        public override bool BalanceEnquiry()
        {
            return true;
        }
    }
}
using Nov18th2016.Context;
using Nov18th2016.State;

namespace Nov18th2016.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// Active indicates that account is in working state
    /// </remarks>
    /// </summary>
    public class Active : AccountState
    {
        public Active(AccountState accountState) :
            this(accountState.Account)
        {
        }

        public Active(Account account)
        {
            this.account = account;
        }

        public override bool Deposit()
        {
            return true;
        }

        public override bool WithDraw()
        {
            return true;
        }

        public override bool BalanceEnquiry()
        {
            return true;
        }
    }
}

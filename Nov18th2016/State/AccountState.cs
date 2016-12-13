using Nov18th2016.Context;

namespace Nov18th2016.State
{
    public abstract class AccountState
    {
        protected Account account;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public abstract bool Deposit();
        public abstract bool WithDraw();
        public abstract bool BalanceEnquiry();
    }
}

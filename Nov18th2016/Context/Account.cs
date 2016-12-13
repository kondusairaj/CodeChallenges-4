using Nov18th2016.ConcreteState;
using Nov18th2016.State;
using System;
using System.Collections;

namespace Nov18th2016.Context
{
    public class Account
    {
        private AccountState _accountState;
        public AccountState AccountState
        {
            get { return _accountState; }
            set { _accountState = value; }
        }
        public Account(string accountState)
        {
            this._accountState = GetAccountState(accountState);
        }

        public void Deposit()
        {
            Console.WriteLine(_accountState.Deposit());
            Console.WriteLine(this._accountState.GetType().Name);
        }

        public void WithDraw()
        {
            Console.WriteLine(_accountState.WithDraw());
            Console.WriteLine(this._accountState.GetType().Name);
        }

        public void BalanceEnquiry()
        {
            Console.WriteLine(_accountState.BalanceEnquiry());
            Console.WriteLine(this._accountState.GetType().Name);
        }

        /// <summary>
        /// Get Account State based on string
        /// </summary>
        /// <param name="accountState"></param>
        /// <returns></returns>
        private AccountState GetAccountState(string accountState)
        {
            switch (accountState.ToLower())
            {
                case "active":
                    return new Active(this);
                case "closed":
                    return new Closed(this);
                default:
                    return new InOperative(this);
            }
        }
    }
}
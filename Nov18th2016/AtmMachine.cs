using Nov18th2016.Context;
using System;

namespace Nov18th2016
{
    /// <summary>
    /// This program implemets STATE PATTERN which allows an Account to behave differently depending on its operation. 
    /// The difference in behavior is delegated to State objects called Active, Closed and InOperative.
    /// </summary>
    public class AtmMachine
    {
        public static void Main(string[] args)
        {
            try
            {
                string operation = Console.ReadLine();
                string accountState = Console.ReadLine();

                Account account = new Account(accountState);

                if (operation != null)
                {
                    switch (operation.ToLower())
                    {
                        case "deposit":
                            account.Deposit();
                            break;
                        case "withdraw":
                            account.WithDraw();
                            break;
                        default:
                            account.BalanceEnquiry();
                            break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
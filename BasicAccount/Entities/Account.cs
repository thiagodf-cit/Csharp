using BasicAccount.Entities.Exceptions;

namespace BasicAccount.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new AccountException("The amount exceeds the balance");
            }

            Balance -= amount;
        }
    }
}

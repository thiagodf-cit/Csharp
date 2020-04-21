using System;

namespace BasicAccount.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}

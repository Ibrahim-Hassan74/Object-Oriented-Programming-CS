namespace maincs
{
    public class BankAccount
    {
        private string _accountno;
        private string _holder;
        private decimal _amount;
        public string Account => _accountno;
        public string Holder => _holder;
        public decimal Amount => _amount;
        public event EventHandler OnNegativeBalance;
        public BankAccount() { }
        public BankAccount(string accountno, string holder, decimal amount)
        {
            _accountno = accountno;
            _holder = holder;
            _amount = amount;
        }
        public void Deposit(decimal amount) => _amount += amount;
        public void Withdraw(decimal amount)
        {
            _amount -= amount;
            if (_amount < 0)
            {
                OnNegativeBalance(this, null);
            }
        }
        public override string ToString() => $"{{ Account Number: {_accountno} , Holder: {_holder} , Balance: ${_amount} }}";
    }
}

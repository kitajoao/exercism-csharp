using System;

public class BankAccount
{
    private decimal _balance;
    private bool openAccount = true;
    public void Open()
    {
        Balance = 0;
    }
    public void Close()
    {
        openAccount = false;

    }
    public decimal Balance
    {
        get
        {
            if (openAccount == false)
                throw new InvalidOperationException();
            return _balance;
        }
        set
        {
            _balance = value;
        }
    }
    public void UpdateBalance(decimal change)
    {
        lock (this)
        {
            Balance += change;
        }
    }
}

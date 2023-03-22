using System;

// Lớp tài khoản
class Account
{
    protected double balance;

    public Account(double initialize)
    {
        balance = initialize;
    }

    public virtual void Deposit(double money)
    {
        if (money <= 0)
        {
            Console.WriteLine("Số tiền không hợp lệ!");
            return;
        }
        balance += money;
        Console.WriteLine($"Gửi tiền thành công! Số dư tài khoản của bạn là {balance}.");
    }

    public virtual void Withdraw(double money)
    {
        if (money <= 0)
        {
            Console.WriteLine("Số tiền không hợp lệ!");
            return;
        }
        if (money > balance)
        {
            Console.WriteLine("Không đủ số dư để rút tiền!");
            return;
        }
        balance -= money;
        Console.WriteLine($"Rút tiền thành công! Số dư tài khoản của bạn là {balance}.");
    }

    public double GetBalance()
    {
        return balance;
    }
}

// Lớp tài khoản tiết kiệm
class SavingAccount : Account
{
    private double rate;

    public SavingAccount(double initialize, double rate) : base(initialize)
    {
        this.rate = rate;
    }

    public double GetInterest()
    {
        double interest = balance * rate;
        balance += interest;
        return interest;
    }
}

// Lớp tài khoản vãng lai
class CheckingAccount : Account
{
    private double feeTransfer;

    public CheckingAccount(double balance, double feeTransfer) : base(balance)
    {
        this.feeTransfer = feeTransfer;
    }

    public override void Deposit(double money)
    {
        if (money <= 0)
        {
            Console.WriteLine("Số tiền không hợp lệ!");
            return;
        }
        balance += money - feeTransfer;
        Console.WriteLine($"Gửi tiền thành công! Số dư tài khoản của bạn là {balance}.");
    }

    public override void Withdraw(double money)
    {
        if (money <= 0)
        {
            Console.WriteLine("Số tiền không hợp lệ!");
            return;
        }
        if (money > balance)
        {
            Console.WriteLine("Không đủ số dư để rút tiền!");
            return;
        }
        balance -= money + feeTransfer;
        Console.WriteLine($"Rút tiền thành công! Số dư tài khoản của bạn là {balance}.");
    }

}

// Lớp chương trình
class Program
{
    static void Main(string[] args)
    {
        Account a = new Account(1000);
        Console.WriteLine($"Số dư tài khoản của bạn là {a.GetBalance()}.");
        a.Deposit(500);
        Console.WriteLine($"Số dư tài khoản của bạn là {a.GetBalance()}.");
        a.Withdraw(200);
        Console.WriteLine($"Số dư tài khoản của bạn là {a.GetBalance()}.");

        SavingAccount sa = new SavingAccount(1000, 0.05);
        Console.WriteLine($"Số dư tài khoản của bạn là {sa.GetBalance()}.");
        double interest = sa.GetInterest();
        Console.WriteLine($"Bạn đã nhận được {interest}");
    }
}

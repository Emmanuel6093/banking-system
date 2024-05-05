class Account 
{

public int AccountNumber { get; private set; }
public string OwnerName {get; private set; }
public decimal Balance {get; private set; } 

// Constructor to create a new account
public Account(int AccountNumber, string OwnerName, decimal InitialDeposit)
{
    AccountNumber = AccountNumber;
    OwnerName = OwnerName;
    Balance = InitialDeposit;
}

// Method to deposit money
public void Deposit(decimal amount)
{
    if (amount > 0)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C} deposited successfully. New balance is {Balance:C}. ");
    }
    else 
    {
        Console.WriteLine("Invalid amount. Deposit must be positive.");
    }
}

// Method to withdraw money from account
public void Withdraw(decimal amount) 
{
    if (amount <= Balance && amount > 0)
    {
        Balance -= amount;
        Console.WriteLine($"{amount:C} withdrawn successfully. Remaining balance is {Balance:C}");
    }
    else 
    {
        Console.WriteLine("Insufficient funds or invalid amount.");
    }
}

// Method to display the account balance
public void DisplayBalance()
{
    Console.WriteLine($"The balance for account {AccountNumber} is {Balance:C}");
}
}
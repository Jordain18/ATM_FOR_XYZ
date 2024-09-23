// See https://aka.ms/new-console-template for more information

//Main Program 

//  ATM Interface Menu 



//class goes here 

public class Account
{
    private double _accountBalance;

    public Account(double initialBalance)
    {
        if (initialBalance >= 1000.0)
        {
            _accountBalance = initialBalance;
        }

        else if (initialBalance! >= 1000.0)
        {
            initialBalance = 0;
            Console.WriteLine("Initial balance was invalid");

        }

        else
        {
            Console.WriteLine("Incorrect Input !");
        }
    }
    // Method

   public void PrintATMMenu()
    {
        Console.WriteLine("--- Welcome To The XYZ ATM ---");
        Console.WriteLine();
        Console.WriteLine("Select '1' - To  Check Account Balance");
        Console.WriteLine("Select '2' - To  Credit Account");
        Console.WriteLine("Select '3' -   To Debit Account");
        Console.WriteLine("Select '4' - To  Exit The ATM ");

    }
    public void Credit(double amount)
    {
        if (amount > 0)
        {
            _accountBalance += amount;
        }
        else if (amount < 0)
        {
            Console.WriteLine("Cannot Accepted Negative Value");
        }


    }
    public void Debit(double amount)
    {

        if ( amount <= 1000)
        {
            _accountBalance -= amount;

        }
        else if (amount > 1000)
        {

            Console.WriteLine("Debit amount exceeded account balance");
        }



    }

      public double GetBalance()
    {
        return _accountBalance;
    }
}


//int choice = 0;

//switch (choice)
//{
//    case 1:
//}
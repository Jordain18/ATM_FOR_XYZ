// See https://aka.ms/new-console-template for more information

//Main Program 

using System.Diagnostics.Tracing;
using System.Xml.Serialization;

int select = 0;

Console.WriteLine("Please enter the Initial Value , Mininum a Thousand dollars ($1,000.00)");
double balance = Convert.ToDouble(Console.ReadLine());
if ( balance < 1000)
{

    Console.WriteLine("  Only going accept Mininum a Thousand dollars ($1,000.00)");
    

}
else
{
    Account account = new Account(balance);
    do
    {
        account.PrintATMMenu();
        select = Convert.ToInt32(Console.ReadLine());

        if (select == 1)
        {
            balance = account.GetBalance();
            Console.WriteLine($" Your balance is {account.GetBalance()}");

        }
        else if (select == 2)
        {
            Console.WriteLine("Please enter the  Amount you  want take from the credit account");
            double creditamount = Convert.ToDouble(Console.ReadLine());

            account.Credit(creditamount);

            Console.WriteLine($" Your New Balance is {account.GetBalance()}");
        }
        else if (select == 3)
        {
            Console.WriteLine("Please enter the  Amount you  want take from the credit account");
            double debitamount = Convert.ToDouble(Console.ReadLine());

            account.Debit(debitamount);

            Console.WriteLine($" Your New Balance is {account.GetBalance()}");


        }
        else if (select == 4)
        {
            Console.Write(" Thank You for using  XYZ ATM  have an Nice Day");
            break;
        }

        else
        {
            Console.WriteLine("Input Incorrect");
        }
    } while (select != 4);

}


//int choice = 0;

//switch (choice)
//{
//    case 1:
//}
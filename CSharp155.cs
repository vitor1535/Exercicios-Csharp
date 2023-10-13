using csharp;
using System.Collections.Generic;


try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account acc = new Account(number, holder, balance, withdrawLimit);

    Console.Write("Enter the amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine());

    acc.Withdraw(withdraw);

    Console.Write("New balance: " + acc.Balance);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}

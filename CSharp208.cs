
using csharp;

Console.WriteLine("Enter the contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());
Console.Write("Enter the number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract c1 = new Contract(number, date, contractValue, new IPaypal(new DateTime(2023, 09, 21),contractValue));
double[] result = c1.Installment.Parcel(contractValue, months);

int i = 1;
foreach(double x in result)
{
    Console.Write(c1.Date.AddMonths(i));
    Console.WriteLine(" " + x);
    i++;
}

using csharp;
using System.Collections.Generic;


List<Pessoa> list = new List<Pessoa>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tax payer #{i+1} data: ");
    Console.Write("Individual or company (i/c)?");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double rendaAnual = double.Parse(Console.ReadLine());

    if (answer == 'i')
    {
        Console.Write("Health expenditures: ");
        double gastoSaude = double.Parse(Console.ReadLine());

        Pessoa p = new PessoaFisica(name, rendaAnual, gastoSaude);
        list.Add(p);
    }
    else if (answer == 'c')
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());

        Pessoa p = new PessoaJuridica(name, rendaAnual, employees);
        list.Add(p);
    }
}

double sum = 0;
foreach (Pessoa pessoa in list)
{
    sum += pessoa.Imposto();
}

Console.WriteLine();
foreach (Pessoa pessoa in list)
{
Console.WriteLine(pessoa.Nome + ": $" + pessoa.Imposto().ToString("F2"));
}
Console.WriteLine("TOTAL TAXES: $" + sum);

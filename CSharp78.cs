using System.Collections.Generic;
using csharp;

//1
int n;
int id;
string nome;
double salario;
int x;
double aumento;
bool idEncontrado = false;

Console.WriteLine("Quantos empregados serao registrados? ");
n = int.Parse(Console.ReadLine());

List<Funcionarios78> lista = new List<Funcionarios78>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Employee #{0}", i + 1);

    Console.Write("Id: ");
    id = int.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Salario: ");
    salario = double.Parse(Console.ReadLine());

    lista.Add(new Funcionarios78(id, nome, salario));
}

Console.Write("Insira o id do employee que tera um aumento: ");
x = int.Parse(Console.ReadLine());

Console.Write("Qual a porcentagem do aumento?");
aumento = double.Parse(Console.ReadLine());

foreach (Funcionarios78 i in lista)
{
    if (i.Id == x)
    {
        i.Aumento(aumento);
        idEncontrado = true;
    }
}

if (idEncontrado == false)
{
    Console.WriteLine("ID NAO EXISTE!");
}

foreach (Funcionarios78 i in lista)
{
    Console.WriteLine(i);
}

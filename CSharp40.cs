//using csharp;


//1
Cadastro pessoa1, pessoa2;

pessoa1 = new Cadastro();
pessoa2 = new Cadastro();

Console.WriteLine("Dados da primeira pessoa: ");
pessoa1.nome = Console.ReadLine();
pessoa1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
pessoa2.nome = Console.ReadLine();
pessoa2.idade = int.Parse(Console.ReadLine());

if (pessoa1.idade > pessoa2.idade)
{
    Console.WriteLine("Mais velho = {0}",pessoa1.nome);
}
else
{
    Console.WriteLine("Mais velho = {0}",pessoa2.nome);
}


//2

Funcionario42 pessoa1, pessoa2;

pessoa1 = new Funcionario42();
pessoa2 = new Funcionario42();

Console.WriteLine("Insira os dados da primeira pessoa: ");
pessoa1.Nome = Console.ReadLine();
pessoa1.Salario = int.Parse(Console.ReadLine());

Console.WriteLine("Insira os dados da segunda pessoa: ");
pessoa2.Nome = Console.ReadLine();
pessoa2.Salario = int.Parse(Console.ReadLine());

Console.WriteLine("Salario medio = {0}",(pessoa1.Salario + pessoa2.Salario) / 2);

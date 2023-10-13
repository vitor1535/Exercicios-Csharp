//using csharp;


//1
Retangulo45 x;
x = new Retangulo45();

Console.WriteLine("Insira altura e largura: ");
x.Altura = double.Parse(Console.ReadLine());
x.Largura = double.Parse(Console.ReadLine());

Console.WriteLine("Area = {0}",x.Area());
Console.WriteLine("Perimetro = {0}",x.Perimetro());
Console.WriteLine("Diagonal = {0}",x.Diagonal());



//2
Funcionario45 p1;
p1 = new Funcionario45();

Console.WriteLine("Nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine("Salario bruto: ");
p1.SalarioBruto = double.Parse(Console.ReadLine());

Console.WriteLine("Imposto: ");
p1.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine(p1);

Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
double aux = double.Parse(Console.ReadLine());
p1.AumentarSalario(aux);

Console.WriteLine(p1);


//3

Aluno45 a1;
a1 = new Aluno45();

Console.WriteLine("Digite o nome do aluno: ");
a1.Nome = Console.ReadLine();

Console.WriteLine("Digite as tres notas do aluno: ");
a1.Nota1 = double.Parse(Console.ReadLine());
a1.Nota2 = double.Parse(Console.ReadLine());
a1.Nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota final = {0}",a1.NotaFinal());

a1.CalcularSituacao();
Console.WriteLine(a1.Situacao);

if (a1.Situacao == "REPROVADO")
{
    Console.WriteLine(a1.PontosFaltantes());
}



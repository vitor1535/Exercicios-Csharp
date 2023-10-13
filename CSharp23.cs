using System;

Console.WriteLine("Insira o seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem sua casa: ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço do produto: ");
float preco = float.Parse(Console.ReadLine());

Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
string infos = Console.ReadLine();

string[] vetor = infos.Split();
string ultNome = vetor[0];
int idade = int.Parse(vetor[1]);
float altura = float.Parse(vetor[2]);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco);
Console.WriteLine(ultNome);
Console.WriteLine(idade);
Console.WriteLine(altura);


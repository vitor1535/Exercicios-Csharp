
using System;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.00;
double preco2 = 650.50;
double medida = 53.234567;


Console.WriteLine("Produtos:");
Console.WriteLine("{0}, cujo preço é ${1:f2}",produto1, preco1);
Console.WriteLine("{0}, cujo preço é $ {1:f2}",produto2, preco2);
Console.WriteLine("{0} anos de idade, código {1} e gênero: {2}",idade, codigo, genero);
Console.WriteLine("Medida com 8 casas decimais: {0:f8}",medida);
Console.WriteLine("Aredondado (três casas decimais): {0:f3}", medida);

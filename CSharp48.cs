//using csharp;


//1
double cotacao, qtd, resultado;

Console.WriteLine("Qual a cotacao do dolar? ");
cotacao = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos dolares voce quer comprar?");
qtd = double.Parse(Console.ReadLine());

resultado = ConversorDeMoeda.Converter(cotacao,qtd);

Console.WriteLine("Valor a ser pago em reais = {0}",resultado);

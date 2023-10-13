
int x, y;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

Console.WriteLine("SOMA = {0}", x + y);



float pi = 3.14159F;
float raio = float.Parse(Console.ReadLine());
float area = (raio * raio) * pi;

Console.WriteLine("A = {0:f4}",area);



int a, b, c, d;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());

int resultado = (a * b) - (c * d);

Console.WriteLine("DIFERENCA = {0}",resultado);



float codigo;
float horas;
float salarioHora;
float salario;

codigo = float.Parse(Console.ReadLine());
horas = float.Parse(Console.ReadLine());
salarioHora = float.Parse(Console.ReadLine());
salario = horas * salarioHora;

Console.WriteLine("NUMBER = {0}",codigo);
Console.WriteLine("SALARY = U${0}",salario);



float codigo1, quantidade1, preco1, codigo2, quantidade2, preco2, total1, total2;
string[] aux;
string[] aux2;

aux = Console.ReadLine().Split();
aux2 = Console.ReadLine().Split();

codigo1 = float.Parse(aux[0]);
quantidade1 = float.Parse(aux[1]);
preco1 = float.Parse(aux[2]);

codigo2 = float.Parse(aux2[0]);
quantidade2 = float.Parse(aux2[1]);
preco2 = float.Parse(aux2[2]);

total1 = quantidade1 * preco1;
total2 = quantidade2 * preco2;

float totalGeral = total1 + total2;

Console.WriteLine("TOTAL A PAGAR = R${0}", totalGeral);



using System.Collections.Generic;
using csharp;


//1
string[] vet;
int m,n;
int num;

vet = Console.ReadLine().Split(' ');
m = int.Parse(vet[0]);
n = int.Parse(vet[1]);

int[,] matriz = new int[m,n];

// preenche matriz
for (int i = 0; i < m; i++)
{
    vet = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        matriz[i,j] = int.Parse(vet[j]);
    }
}

// mostra matriz
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matriz[i,j] + " ");
    }
    
    Console.WriteLine();
}

//numero a ser procurado
num = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matriz[i,j] == num)
        {
            Console.WriteLine("Position {0},{1}",i,j);
            if (j - 1 >= 0)
            {
            Console.WriteLine("Left: {0}",matriz[i,j-1]);
            }
            if (j + 1 < n)
            {
            Console.WriteLine("Right: {0}",matriz[i,j+1]);
            }
            if (i - 1 >= 0)
            {
            Console.WriteLine("Up: {0}",matriz[i-1,j]);
            }
            if (i + 1 < m)
            {
            Console.WriteLine("Down: {0}",matriz[i+1,j]);
            }
        }
    }
    
    Console.WriteLine();
}

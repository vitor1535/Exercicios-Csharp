using csharp;
using System.Collections.Generic;
using System.Globalization;


string sourcePath = @"C:\Users\Vitor\Downloads\csharp201\bloco1.txt";
string targetPath = @"C:\Users\Vitor\Downloads\csharp201\out.csv";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            string[] aux = line.Split(',');
            Console.Write(aux[1]);
            Console.Write(aux[2]);
            double num1 = double.Parse(aux[1]);
            double num2 = double.Parse(aux[2]);

            sw.WriteLine(aux[0] + "," + (num1 * num2 / 100));

            Console.WriteLine();
        }
        
    }
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}

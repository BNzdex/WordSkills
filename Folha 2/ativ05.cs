using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] arquivo = File.ReadAllLines("aluno.txt");
        foreach (var linha in arquivo)
        {
            Console.WriteLine(linha);
        }
    }
}

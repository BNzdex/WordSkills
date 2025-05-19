using System;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("Bernardo");
        string caminho_pasta = Path.Combine("Bernardo", "dados.txt");

        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua nota: ");
        int nota = int.Parse(Console.ReadLine());

        File.WriteAllText(caminho_pasta,$"Nome do aluno: {nome}\nNota: {nota}");

        
    }
}

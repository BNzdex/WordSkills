using System;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("Bernardo");
        string caminho_pasta = Path.Combine("Bernardo", "arquivo.txt");
        string[] arquivos = Directory.GetFiles("Bernardo");

        for (int i = 0; i < arquivos.Length; i++)
            Console.WriteLine($"{i + 1}. {Path.GetFileName(arquivos[i])}");

        Console.WriteLine("Qual dessas opções você deseja excluir ? ");
        int escolha = int.Parse(Console.ReadLine());
        File.Delete(arquivos[escolha - 1]);
    }
}

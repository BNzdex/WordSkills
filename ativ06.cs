using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        nome_idade(nome, idade); 
    }

    static void nome_idade(string nome, int idade) 
    {
        Console.WriteLine($"\nNome: {nome}\nIdade: {idade}");
     
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade");
        }
        else
        {
            Console.WriteLine("Você é menor de idade");
        }
    }
}

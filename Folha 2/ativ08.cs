using System;
using System.IO;

class Program
{
    static void Main()
    {
        string caminho = "frases.txt";
        string frase;
        string linha;

        using (StreamWriter writer = new StreamWriter(caminho))
        {
            while (true)
            {
                Console.Write("Digite uma frase (ou 'sair' para finalizar): ");
                frase = Console.ReadLine();

                if (frase.ToLower() == "sair")
                    break;

                writer.WriteLine(frase);
            }
        }

        Console.WriteLine("Frases digitadas:");
        using (StreamReader reader = new StreamReader(caminho))
        {
            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
}

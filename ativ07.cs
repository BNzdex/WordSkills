using System;
class Program
{
    static void Main()
    {
        int total = 0;
        int[] array = { 2, 4, 6, 8, 10 };
        string[] array_nomes = { "Bernardo", "Ana Júlia", "Raphael", "Alfredo" };

        foreach (int n1 in array)
        {
            total += n1;
        }

        int media = total / 5;
        Console.Write($"Média: {media}");


        foreach (string nome  in array_nomes)
        {
            if (nome.StartsWith("A"))
            {
                Console.WriteLine($"Os nome que começam com A são {nome}");
            }
        }
    }
}

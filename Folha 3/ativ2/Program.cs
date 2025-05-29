using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Bem-vindo ao atendimento virtual!");
        Console.WriteLine("*********************************");

        while (true)
        {
            Class2.ExibirMenu();
            string opcao = Console.ReadLine();
            if (Class2.ProcessarOpcao(opcao))
                break;
        }

        File.WriteAllLines("chatlog.txt", Class2.historico);
        Console.WriteLine("Histórico da conversa salvo em 'chatlog.txt'.");
    }
}

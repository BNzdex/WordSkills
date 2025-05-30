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
            string horario = DateTime.Now.ToString("HH:mm");  


            if (Class2.comandos_interativos(opcao, horario))
                continue;

            if (Class2.ProcessarOpcao(opcao, horario))
                break;
        }

        Console.WriteLine("De 1 a 10, como você avalia nosso atendimento? ");
        int nota = int.Parse(Console.ReadLine());
        Class2.historico.Add($"Avaliação: {nota}");
        Console.WriteLine("Obrigado pela sua avaliação!!!\n");

        File.WriteAllLines("chatlog.txt", Class2.historico);
        Console.WriteLine("Histórico da conversa salvo em 'chatlog.txt'.");
    }
}

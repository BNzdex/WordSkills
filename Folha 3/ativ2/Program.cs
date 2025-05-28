using System;

class Aluno
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
    }

}
using System;
using System.ComponentModel;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- MENU PRINCIPAL ---");
        Console.WriteLine("1. Cadastrar cliente");
        Console.WriteLine("2. Fazer novo pedido");
        Console.WriteLine("3. Listar pedidos");
        Console.WriteLine("4. Finalizar pedido");
        Console.WriteLine("5. Histórico de pedidos por cliente");
        Console.WriteLine("6. Sair so sistema");
        Console.WriteLine("O que deseja fazer? ");
        string opcao = Console.ReadLine();


        if (opcao.ToUpper().Contains("CADASTRAR") || opcao == "1")
        {
            Console.WriteLine("Aplicar função para cadstro de cliente");
        }
        else if (opcao.ToUpper().Contains("FAZER") || opcao == "2")
        {
            Console.WriteLine("Aplicar função para solocitar pedido");
        }
        else if (opcao.ToUpper().Contains("LISTAR") || opcao == "3")
        {
            Console.WriteLine("Aplicar função para listar pedidos");
        }
        else if (opcao.ToUpper().Contains("FINALIZAR") || opcao == "4")
        {
            Console.WriteLine("Aplicar função para finalizar pedido");
        }
        else if (opcao.ToUpper().Contains("HISTÓRICO") || opcao == "5")
        {
            Console.WriteLine("Aplicar função para puxar historico do cliente");
        }
        else if (opcao.ToUpper().Contains("SAIR") || opcao == "6")
        {
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }

    }
}











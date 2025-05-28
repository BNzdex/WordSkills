using System;
using System.Collections.Generic;

public class Class2
{
    public static void ExibirMenu()
    {
        Console.WriteLine("Digite uma opção: ");
        Console.WriteLine("1- Informações sobre produtos");
        Console.WriteLine("2- Suporte técnico");
        Console.WriteLine("3- Falar com atendente");
        Console.WriteLine("0- Encerrar conversa");
        Console.WriteLine("O que deseja fazer ? ");
    }

    public static bool ProcessarOpcao(string opcao)
    {
        if (opcao == "1" || opcao.ToUpper() == "INFORMAÇÕES SOBRE PRODUTOS")
        {
            Console.WriteLine("Temos os seguites produtos: Notebook, Monitor, Teclado");
        }
        else if (opcao == "2" || opcao.ToUpper() == "SUPORTE TÉCNICO")
        {
            Console.WriteLine("Para suporte técnico, acesse: mytech.com");
        }
        else if (opcao == "3" || opcao.ToUpper() == "FALAR COM ATENDENTE")
        {
            Console.WriteLine("Um atendente estará com você em breve");
        }
        else if (opcao == "0" || opcao.ToUpper() == "ENCERRAR CONVERSA")
        {
            Console.WriteLine("Até mais!");
            return true;
        }
        else if (opcao.ToUpper() == "OLÁ")
        {
            Console.WriteLine("Olá");
        }
        else if (opcao.ToUpper() == "OLÁ, BOM DIA" || opcao.ToUpper() == "OLÁ BOM DIA" || opcao.ToUpper() == "BOM DIA")
        {
            Console.WriteLine("Olá, bom dia");
        }
        else if (opcao.ToUpper() == "OLÁ, BOA TARDE" || opcao.ToUpper() == "OLÁ BOA TARDE" || opcao.ToUpper() == "BOA TARDE")
        {
            Console.WriteLine("Olá, boa tarde");
        }
        else
        {
            Console.WriteLine("Opção inválida, tente novamente");
        }

        return false;
    }
}


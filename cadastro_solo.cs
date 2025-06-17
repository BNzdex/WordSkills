using System.IO;
using System.Collections.Generic;
using ClosedXML.Excel;

class Program
{
    static void Main()
    {
        Console.WriteLine("***************************************");
        Console.WriteLine("Sistema de Cadastro de Análises de Solo");
        Console.WriteLine("***************************************");

        while(true)
        {
          Console.WriteLine("O que deseja fazer ?");
          Console.WriteLine("1- Cadastrar uma nova análise\n2- Listar todas análises cadastradas");
          Console.WriteLine("Escolha uma das opções: ");
          string opcao = Console.ReadLine();
          
          if (opcao.ToUpper().Contains("CADASTRAR") || opcao == "1")
          {
              Console.WriteLine("VSDVSDVv");
              
          }
          else if (opcao.ToUpper().Contains("LISTAR") || opcao == "2")
          {
              Console.WriteLine("DDDVSVCS")    
          }
          else if (opcao.ToUpper().Contains("SAIR") || opcao == "3")
          {
              Console.WriteLine("Até mais!!!")
              return false
          }
          else
              Console.WriteLine("Opção inválida! Tente novamente.")
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

public class ControleGastos
{
    public static List<string> log = new List<string>();
    public static void Main()
    {
        string[] descricao = new string[30];
        double?[] valor = new double?[30];
        string[] data = new string[30];
        int numero_cadastros = 0;


        Console.WriteLine("\n*************************************");
        Console.WriteLine("Sistema de Controle de Gastos Mensais");
        Console.WriteLine("*************************************");

        while (true)
        {
            File.AppendAllLines("gastos_mensais.txt", log);

            Console.WriteLine("\nDigite uma opção: ");
            Console.WriteLine("1- Cadastrar Gastos");
            Console.WriteLine("2- Listar Gastos");
            Console.WriteLine("3- Ver o valor total de gastos no mês");
            Console.WriteLine("4- Remover Gasto");
            Console.WriteLine("5- Sair do Sistema");
            Console.WriteLine("O que deseja fazer ? ");
            string opcao = Console.ReadLine();

            if (opcao.ToLower().Contains("cadastrar") || opcao == "1")
            {
                Console.WriteLine("Deseja cadastrar quantos gastos ? ");
                int num_cadastros = int.Parse(Console.ReadLine());
                numero_cadastros = numero_cadastros + num_cadastros;

                for (int i = 0; i < num_cadastros; i++)
                {
                    numero_cadastros++;
                    log.Add($"Cadastro {numero_cadastros}");
                    Console.WriteLine($"\n{i + 1}° Cadastro");

                    Console.WriteLine($"Descreva o gasto {i + 1}: ");
                    descricao[i + numero_cadastros] = Console.ReadLine();
                    log.Add($"Descrição: {descricao[i + numero_cadastros]}");

                    Console.WriteLine($"Valor do gasto {i + 1}: ");
                    valor[i + numero_cadastros] = double.Parse(Console.ReadLine());
                    log.Add($"Descrição: {valor[i + numero_cadastros]}");

                    Console.WriteLine($"Data do gasto {i + 1} (ex: 20/06/2025): ");
                    data[i + numero_cadastros] = Console.ReadLine();
                    log.Add($"Descrição: {data[i + numero_cadastros]}");

                }
            }
            else if (opcao.ToLower().Contains("listar") || opcao == "2")
            {
                string[] arquivo = File.ReadAllLines("gastos_mensais.txt");
                foreach (var linha in arquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else if (opcao.ToLower().Contains("valor total") || opcao == "3")
            {
                double valor_total = 0;
                int y = valor.Length;
                for (int i = 0; i < y; i++)
                {
                    if (valor[i].HasValue)
                        valor_total += valor[i].Value;
                }
                Console.WriteLine($"O valor total gasto no mês foi: {valor_total}");
                log.Add($"Atualmente o valor total gasto no mês é: {valor_total}");
            }
            else if (opcao.ToLower().Contains("remover") || opcao == "4")
            {
                for (int i = 0; i <  numero_cadastros; i++)
                {
                    Console.WriteLine($"{i + 1}- {descricao[i]}");
                }
                Console.WriteLine("Qual o número do gasto que você deseja remover ? ");
                int num_cadastroo = int.Parse(Console.ReadLine());

                int n1 = num_cadastroo - 1;

                for (int i = 0;i < numero_cadastros; i++)
                {
                    if (numero_cadastros == n1)
                    {
                        descricao[n1] = null;
                        valor[n1] = null;
                        data[n1] = null;
                    }
                }
            }

            else
            {
                Console.WriteLine("Até mais");
                break;
            }
        }
    }
}



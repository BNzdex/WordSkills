using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n***************************************");
        Console.WriteLine("Sistema de Cadastro de Análises de Solo");
        Console.WriteLine("***************************************");
        List<AnaliseSolo> analises = CadastroSolo.CarregarAnalises();

        while (true)
        {
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1- Cadastrar uma nova análise\n2- Listar todas análises cadastradas\n3- Sair do sistema");
            Console.WriteLine("Escolha uma das opções: ");
            string opcao = Console.ReadLine();

            if (opcao.ToUpper().Contains("CADASTRAR") || opcao == "1")
            {
                Console.WriteLine("Digite o nome da propriedade: ");
                string nome_propriedade = Console.ReadLine();
                Console.WriteLine("Data de coleta (ex: 17/06/2025): ");
                string data_coleta = Console.ReadLine();
                Console.WriteLine("Digite o pH do solo: ");
                double ph = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Fósforo (P) do solo: ");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Potássio (K) do solo: ");
                double k = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Magnésio (Mg) do solo: ");
                double mg = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Cálcio (Ca) do solo: ");
                double ca = double.Parse(Console.ReadLine());

                AnaliseSolo analiseSolo = new AnaliseSolo
                {
                    NomePropriedade = nome_propriedade,
                    DataColeta = data_coleta,
                    Ph = ph,
                    Fosforo = p,
                    Potassio = k,
                    Magnesio = mg,
                    Calcio = ca
                };

                analises.Add(analiseSolo);
                CadastroSolo.SalvarAnalises(analises);

                Console.WriteLine("Análise salva com sucesso!");
            }
            else if (opcao.ToUpper().Contains("LISTAR") || opcao == "2")
            {
                foreach(var analise in analises)
                {
                    Console.WriteLine($"\nNome da propriedade: {analise.NomePropriedade}");
                    Console.WriteLine($"Data da coleta: {analise.DataColeta}");
                    Console.WriteLine($"Potencial Hidrogeniônico (pH) do solo: {analise.Ph}");
                    Console.WriteLine($"Fósforo (P) do solo: {analise.Fosforo}");
                    Console.WriteLine($"Potássio (K) do solo: {analise.Potassio}");
                    Console.WriteLine($"Magnésio (Mg) do solo: {analise.Magnesio}");
                    Console.WriteLine($"Cálcio (Ca) do solo: {analise.Calcio}\n");
                }
            }
            else if (opcao.ToUpper().Contains("SAIR") || opcao == "3")
            {
                Console.WriteLine("Até mais!!!");
                break;
            }
            else
                Console.WriteLine("Opção inválida! Tente novamente.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        string[] nome = new string[10];
        int[] idade = new int[10];
        string[] cidade = new string[10];
        int pessoas_cadastradas = 0;
        bool bglh_dd = true;
         
        while (bglh_dd == true)
        {
            Console.Clear();
            Console.WriteLine("========== Bem-vindo ao cadastro de pessoas ==========\n");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Adicionar cadastro");
            Console.WriteLine("2 - Listar cadastro");
            Console.WriteLine("3 - Buscar cadastro");
            Console.WriteLine("4 - Sair do sistema");
            Console.Write("\nO que você deseja fazer? ");
            string opcao = Console.ReadLine();

            if (opcao == "1" || opcao.ToLower() == "adicionar cadastro")
            {
                for (int y = pessoas_cadastradas; y < 10; y++)
                {
                    Console.WriteLine($"\nCadastro da {y + 1}ª pessoa:");
                    Console.Write("Nome: ");
                    nome[y] = Console.ReadLine();

                    Console.Write("Idade: ");
                    idade[y] = int.Parse(Console.ReadLine());

                    Console.Write("Cidade: ");
                    cidade[y] = Console.ReadLine();

                    pessoas_cadastradas++;

                    Console.Write("\nDeseja cadastrar outra pessoa? \n");
                    Console.WriteLine("1- Sim");
                    Console.WriteLine("2- Não");
                    string resposta = Console.ReadLine().ToLower();

                    if (resposta != "1" && resposta.ToLower() != "sim")
                    {
                        break;
                    }
                }
            }
            else if (opcao == "2" || opcao.ToLower() == "listar cadastro")
            {
                Console.Clear();
                for (int i = 0; i < pessoas_cadastradas; i++)
                {
                    Console.WriteLine($"\nCadastro {i + 1}");
                    Console.WriteLine($"Nome: {nome[i]}");
                    Console.WriteLine($"Idade: {idade[i]}");
                    Console.WriteLine($"Cidade: {cidade[i]}");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (opcao == "3" || opcao.ToLower() == "buscar cadastro")
            {
             
                Console.Write("Digite o nome que deseja buscar: ");
                string nome_busca = Console.ReadLine();
                bool pessoa_buscada = false;

                for (int i = 0; i < pessoas_cadastradas; i++)
                {
                    if (nome[i] != null && nome[i].ToUpper() == nome_busca.ToUpper())
                    {
                        Console.WriteLine($"\nNome: {nome[i]}, Idade: {idade[i]}, Cidade: {cidade[i]}");
                        pessoa_buscada = true;
                        break;
                    }
                }

                if (!pessoa_buscada)
                {
                    Console.WriteLine("\nNome não encontrado.");
                }

            
            }
            else if (opcao == "4" || opcao.ToLower() == "sair do sistema")
            {
                Console.WriteLine("\nValeu fx, é nois tmj");
                bglh_dd = false; 
            }
            else
            {
                Console.WriteLine("\nOpção inválida.");
            }
        }
    }
}

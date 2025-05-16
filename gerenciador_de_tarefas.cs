using System;

class Program
{
    static void Main()
    {
        string[] tarefas_pendentes = new string[10];
        string[] tarefas_concluidas = new string[10];
      

        while (true)
        {

            Console.WriteLine("===== GERENCIADOR DE TAREFAS =====");
            Console.WriteLine("1- Adicionar tarefa");
            Console.WriteLine("2- Listar tarefas");
            Console.WriteLine("3- Marcar tarefa como concluída");
            Console.WriteLine("4- Remover tarefa");
            Console.WriteLine("5- Sair do sistema");
            Console.WriteLine("O que deseja fazer ? ");
            string opcao = Console.ReadLine();

            if (opcao == "1" || opcao.ToLower() == "adicionar tarefa")
            {
                Console.WriteLine("Quantas tarefas deseja adicionar ? ");
                int tarefas = int.Parse(Console.ReadLine());

                for (int i = 0; i < tarefas; i++)
                {
                    Console.WriteLine($"Informe a tarefa {i + 1}: ");
                    tarefas_pendentes[i] = Console.ReadLine();
                    

                }
            }
            else if (opcao == "2" || opcao.ToLower() == "listar tarefas")
            {
                Console.Clear();
                Console.WriteLine("1- Pendentes");
                Console.WriteLine("2- Concluídas");
                Console.WriteLine("Deseja listar qual tipo de tarefa ? ");
                string tipo_tarefa = Console.ReadLine();

                if (tipo_tarefa == "1" || tipo_tarefa.ToLower() == "pendente")
                {
                    for (int i = 0; i < tarefas_pendentes.Length; i++)
                    {
                        if (tarefas_pendentes[i] != null)
                        {
                            Console.WriteLine($"{tarefas_pendentes[i]}");
                        }
                        else if (tarefas_pendentes == null)
                        {
                            Console.WriteLine("Você não tem tarefas pendentes");
                        }

                    }
                }

                else if (opcao == "2" || opcao.ToLower() == "concluídas")
                {
                    for (int i = 0; i < tarefas_concluidas.Length; i++)
                    {
                        if (tarefas_concluidas[i] != null)
                        {
                            Console.WriteLine($"{tarefas_concluidas[i]}");
                        }
                        else if (tarefas_concluidas == null)
                        {
                            Console.WriteLine("Você não tem tarefas concluídas");
                        }
                    }
                }

            }
            else if (opcao == "3" || opcao.ToLower() == "marcar tarefa como concluida")
            {
                for (int i = 0; i < tarefas_pendentes.Length; i++)
                {
                    if (tarefas_pendentes[i] != null)
                    {
                        Console.WriteLine($"{i + 1}° {tarefas_pendentes[i]}");
                    }
                }
                Console.WriteLine("Digite o número da tarefa que deseja marcar como concluída: ");
                int n1 = int.Parse(Console.ReadLine());

                int numero_elemento = n1 - 1;

                if (numero_elemento >= 0 && numero_elemento < tarefas_pendentes.Length && tarefas_pendentes[numero_elemento] != null)
                {
                    for (int i = 0; i < tarefas_concluidas.Length; i++)
                    {
                        if (tarefas_concluidas[i] == null)
                        {
                            tarefas_concluidas[i] = tarefas_pendentes[numero_elemento];
                            break;
                        }
                    }

                    tarefas_pendentes[numero_elemento] = null;
                    Console.WriteLine("Tarefa marcada como concluída com sucesso!");
                }
                else
                {
                    Console.WriteLine("Opção inválida ou tarefa inexistente");
                }
            }
            else if (opcao == "4" || opcao.ToLower() == "remover tarefa")
            {
                Console.WriteLine("1- Pendente");
                Console.WriteLine("2- Concluída");
                Console.WriteLine("Digite o número do tipo de tarefa que você deseja remover: ");
                int n2 = int.Parse(Console.ReadLine());

                if (n2 == 1)
                {
                    for (int i = 0; i < tarefas_pendentes.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}- {tarefas_pendentes[i]}");
                    }
                    Console.WriteLine("Qual o número da tarefa deseja remover ? ");
                    int tarefa_removida = int.Parse(Console.ReadLine());

                    int total = tarefa_removida - 1;

                    for (int i = 0; i < tarefas_pendentes.Length; i++)
                    {
                        if (tarefas_pendentes[i].Length == total)
                        {
                            tarefas_pendentes[total] = null;
                        }

                    }

                    if (n2 == 2)
                    {
                        for (int i = 0; i < tarefas_concluidas.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}- {tarefas_concluidas[i]}");
                        }
                        Console.WriteLine("Qual o número da tarefa deseja remover ? ");
                        int num_tarefaa = int.Parse(Console.ReadLine());

                        int num_tarefa = num_tarefaa - 1;

                        for (int i = 0; i < tarefas_concluidas.Length; i++)
                        {
                            if (tarefas_concluidas[i].Length == num_tarefa)
                            {
                                tarefas_concluidas[num_tarefa] = null;
                            }

                        }

                    }
                    Console.WriteLine("Tarefa removida com sucesso!");

                }
            }
            else if (opcao == "5" || opcao.ToLower() == "sair so sistema")
            {
                Console.WriteLine("É nois, tmj cria");
                break;

            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}

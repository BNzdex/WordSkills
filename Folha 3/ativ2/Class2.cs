using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

public class Class2
{
    public static List<string> historico = new List<string>();

    public static void ExibirMenu()
    {
        Console.WriteLine("\nDigite uma opção: ");
        Console.WriteLine("1- Informações sobre produtos");
        Console.WriteLine("2- Suporte técnico");
        Console.WriteLine("3- Falar com atendente");
        Console.WriteLine("0- Encerrar conversa");
        Console.WriteLine("O que deseja fazer ? ");
    }

    public static bool ProcessarOpcao(string opcao, string horario)
    {
        historico.Add("Usuário: " + opcao);


        if (opcao == "1" || opcao.ToUpper() == "INFORMAÇÕES SOBRE PRODUTOS")
        {
            Console.WriteLine("\nTemos os seguites produtos:");
            Console.WriteLine("1- Notebook: Intel i5, 8GB RAM, SSD 256GB - R$ 2.000,00");
            Console.WriteLine("2- Monitor: 24'' Full HD, HDMI - R$ 650,00");
            Console.WriteLine("3- Teclado: Mecânico RGB, USB - R$ 250,00");
            historico.Add("Bot: Lista de produtos exibida.");

            Console.WriteLine("Digite o número da opção de seu interesse: ");
            int acao_produto = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja:");
            Console.WriteLine("1 - Comprar");
            Console.WriteLine("2 - Ver mais detalhes");
            Console.WriteLine("0 - Voltar ao menu principal");
            int acao = int.Parse(Console.ReadLine());

            if (acao == 1)
            {
                string msg = "Produto adicionado ao carrinho. A finalização será feita por um atendente.";
                Console.WriteLine(msg);
                historico.Add("Bot: " + msg);
            }
            else if (acao == 2)
            {
                string msg = "O produto possui garantia de 1 ano, entrega em 5 dias úteis.";
                Console.WriteLine(msg);
                historico.Add("Bot: " + msg);
            }
            else if (acao == 0)
            {
                Console.WriteLine("Voltando ao menu principal...");
                historico.Add("Bot: Voltando ao menu principal");
            }
            else if (acao_produto > 3)
            {
                Console.WriteLine("Opção inválida!");
                historico.Add("Bot: Opção inválida.");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                historico.Add("Bot: Opção inválida.");
            }
        }
        else if (opcao == "2" || opcao.ToUpper() == "SUPORTE TÉCNICO")
        {
            Console.WriteLine("\nQual o seu problema?");
            Console.WriteLine("1 - Problemas com login");
            Console.WriteLine("2 - Produto com defeito");
            Console.WriteLine("3 - Dúvidas sobre garantia");
            Console.WriteLine("0 - Voltar ao menu principal");
            string problema = Console.ReadLine();
            historico.Add("Usuário: " + problema);

            switch (problema)
            {
                case "1":
                    Console.WriteLine("Para problemas com login, acesse: suporte.mytech.com/login");
                    historico.Add("Bot: Link para suporte de login fornecido.");
                    break;
                case "2":
                    Console.WriteLine("Você pode solicitar assistência técnica pelo WhatsApp: (27) 90000-0000");
                    historico.Add("Bot: WhatsApp de assistência técnica fornecido.");
                    break;
                case "3":
                    Console.WriteLine("Todos os produtos têm 1 ano de garantia. Mais informações: mytech.com/garantia");
                    historico.Add("Bot: Informações de garantia fornecidas.");
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal...");
                    historico.Add("Bot: Voltando ao menu principal.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    historico.Add("Bot: Opção inválida.");
                    break;
            }
        }
        else if (opcao == "3" || opcao.ToUpper() == "FALAR COM ATENDENTE")
        {
            Console.Write("\nInforme seu nome para prosseguir: ");
            string nome = Console.ReadLine();
            historico.Add("Usuário: Nome: " + nome);

            Console.WriteLine($"Obrigado, {nome}. Um atendente estará com você em instantes.");
            Console.WriteLine("Você está na fila de atendimento. Aguarde um momento...");
            historico.Add("Bot: Início do atendimento ao usuário.");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Você será atendido em {i} segundos...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Conectando com o atendente...");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.Write("Descreva brevemente seu problema: ");
            string problema = Console.ReadLine();
            Console.WriteLine("Sua solicitação foi registrada. Um atendente retornará o contato em até 24h.");
            historico.Add("Usuário: " + problema);
            historico.Add("Bot: Solicitação registrada.");
        }
        else if (opcao == "0" || opcao.ToUpper() == "ENCERRAR CONVERSA")
        {
            Console.WriteLine("Até mais!");
            historico.Add($"Bot: Encerrando conversa\nHorário de encerramento: {horario}");
            return true;
        }
        else if (opcao.ToUpper().Contains("TCHAU") || opcao.ToUpper().Contains("VALEU"))
        {
            Console.WriteLine("Valeu mano tmj");
            historico.Add($"Bot: Tchau meu parceiro\nHorário de encerramento: {horario}");
        }
        else
        {
            Console.WriteLine("Opção inválida, tente novamente");
            historico.Add("Bot: Opção inválida.");
        }

        return false;
    }
    public static void MensagemAleatoria(string periodo)
    {
        List<string> respostas = new List<string>
    {
        "Tudo bem, por favor escolha uma das opções abaixo",
        $"{periodo}, fique à vontade para conferir nossos produtos, temos notebooks, teclados e monitores!",
        $"Oi, {periodo}. Como posso ajudar?",
        $"Fala comigo meu parceiro, tá querendo o que hoje? Comprar, suporte, atendimento? Fique à vontade para escolher uma opção no menu.",
        $"{periodo}, fique à vontade para escolher uma das opções do menu",
    };

        Random rng = new Random();
        for (int i = respostas.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            string temp = respostas[i];
            respostas[i] = respostas[j];
            respostas[j] = temp;
        }

        string respostaAleatoria = respostas[0];
        Console.WriteLine(respostaAleatoria);
        historico.Add("Bot: " + respostaAleatoria);
    }

    public static bool comandos_interativos(string opcao, string horario)
    {
        string entrada = opcao.ToUpper();
        int hora = DateTime.Now.Hour;

        string periodo = (hora >= 6 && hora < 12) ? "bom dia" :
                 (hora >= 12 && hora < 18) ? "boa tarde" :
                 "boa noite";


        if (entrada.Contains("OLÁ") || entrada.Contains("OLA"))
        {
            Console.WriteLine($"Olá, {periodo}");
            MensagemAleatoria(periodo);
            return true;
        }
        else if (entrada.Contains("BOM DIA"))
        {
            Console.WriteLine("Olá, bom dia");
            MensagemAleatoria(periodo);
            return true;
        }
        else if (entrada.Contains("BOA TARDE"))
        {
            Console.WriteLine("Olá, boa tarde");
            MensagemAleatoria(periodo);
            return true;
        }
        else if (entrada.Contains("BOA NOITE"))
        {
            Console.WriteLine("Olá, boa noite");
            MensagemAleatoria(periodo);
            return true;
        }
        else if (entrada.Contains("OI"))
        {
            Console.WriteLine($"Kole rlk, {periodo}");
            MensagemAleatoria(periodo);
            return true;
        }
        else if ((entrada.ToLower().Contains("bom dia") && periodo != "bom dia") ||
        (entrada.ToLower().Contains("boa tarde") && periodo != "boa tarde") ||
        (entrada.ToLower().Contains("boa noite") && periodo != "boa noite"))
        {
            Console.WriteLine($"Na verdade é {periodo}, pois agora é {horario}");
            MensagemAleatoria(periodo);
            return true;
        }

        return false;
    }


}

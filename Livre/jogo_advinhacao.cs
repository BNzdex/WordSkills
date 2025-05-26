using System;

class Jogo
{
    static void Abertura()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Bem-vindo ao jogo de Adivinhação!");
        Console.WriteLine("*********************************");
    }

    static int DefinirTentativas()
    {
        int tentativas = 0;
        Console.WriteLine("Qual modo de jogo deseja?");
        Console.WriteLine("1- Fácil");
        Console.WriteLine("2- Médio");
        Console.WriteLine("3- Difícil");
        Console.Write("Defina o nível: ");
        string nivel = Console.ReadLine();

        if (nivel == "1" || nivel.ToUpper() == "FÁCIL")
        {
            tentativas = 20;
        }
        else if (nivel == "2" || nivel.ToUpper() == "MÉDIO")
        {
            tentativas = 15;
        }
        else if (nivel == "3" || nivel.ToUpper() == "DIFÍCIL")
        {
            tentativas = 10;
        }
        else
        {
            Console.WriteLine("Opção inválida. Usando nível fácil por padrão.");
            tentativas = 20;
        }

        return tentativas;
    }

    static int PedeChute()
    {
        Console.Clear();
        Console.Write("Digite um número entre 1 e 1000: ");
        int chute = int.Parse(Console.ReadLine());
        return chute;
    }

    static void VerificaChute(int tentativas, int numeroSecreto, int pontos)
    {
        for (int rodada = 1; rodada <= tentativas; rodada++)
        {
            Console.WriteLine($"\nTentativa {rodada} de {tentativas}");
            int chute = PedeChute();

            if (chute < 1 || chute > 1000)
            {
                Console.WriteLine("Número inválido! Escolha um número entre 1 e 1000.");
                continue;
            }

            if (chute == numeroSecreto)
            {
                Vencer(numeroSecreto, pontos);
                return;
            }
            else
            {
                if (numeroSecreto < chute)
                {
                    Console.WriteLine("\nVocê errou! O seu chute foi maior que o número secreto.");
                }
                else
                {
                    Console.WriteLine("\nVocê errou! O seu chute foi menor que o número secreto.");
                }

                pontos = Pontuacao(pontos, numeroSecreto, chute);
            }
        }

        Fim(numeroSecreto);
    }

    static int Pontuacao(int pontos, int numeroSecreto, int chute)
    {
        int pontosPerdidos = Math.Abs(numeroSecreto - chute);
        pontos -= pontosPerdidos;
        return pontos;
    }

    static void Vencer(int numeroSecreto, int pontos)
    {
        Console.WriteLine("\nVocê acertou!");
        Console.WriteLine("       ___________      ");
        Console.WriteLine("      '._==_==_=_.'     ");
        Console.WriteLine("      .-\\:      /-.    ");
        Console.WriteLine("     | (|:.     |) |    ");
        Console.WriteLine("      '-|:.     |-'     ");
        Console.WriteLine("        \\::.    /      ");
        Console.WriteLine("         '::. .'        ");
        Console.WriteLine("           ) (          ");
        Console.WriteLine("         _.' '._        ");
        Console.WriteLine("        '-------'       ");
        Console.WriteLine($"O número secreto era {numeroSecreto}.");
        Console.WriteLine($"O total de pontos foi de {pontos}.");
    }

    static void Fim(int numeroSecreto)
    {
        Console.WriteLine("\nFim do jogo.");
        Console.WriteLine("    _______________         ");
        Console.WriteLine("   /               \\        ");
        Console.WriteLine("  /                 \\       ");
        Console.WriteLine("//                   \\/\\    ");
        Console.WriteLine("\\|   XXXX     XXXX   | /    ");
        Console.WriteLine(" |   XXXX     XXXX   |/     ");
        Console.WriteLine(" |   XXX       XXX   |      ");
        Console.WriteLine(" |                   |      ");
        Console.WriteLine(" \\__      XXX      __/      ");
        Console.WriteLine("   |\\     XXX     /|        ");
        Console.WriteLine("   | |           | |        ");
        Console.WriteLine("   | I I I I I I I |        ");
        Console.WriteLine("   |  I I I I I I  |        ");
        Console.WriteLine("   \\_             _/        ");
        Console.WriteLine("     \\_         _/          ");
        Console.WriteLine("       \\_______/            ");
        Console.WriteLine($"O número secreto era {numeroSecreto}.");
    }

    static void Main()
    {
        Abertura();
        int tentativas = DefinirTentativas();
        Random random = new Random();
        int numeroSecreto = random.Next(1, 1001);
        int pontos = 10000;
        VerificaChute(tentativas, numeroSecreto, pontos);
    }
}

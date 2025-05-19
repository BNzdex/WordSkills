using System.IO;

class CadastroTXT
{
    static void Main()
    {
        string arquivo = "aluno.txt";
        Console.WriteLine("Cadastro de Alunos");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Pressione qualquer tecla para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.Write($"Digite o nome do Aluno {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite a idade do Aluno {i + 1}: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write($"Qual o Curso do Aluno {i + 1}? ");
            string curso = Console.ReadLine();
            Console.Clear();
            File.AppendAllText(arquivo, $"\n Nome: {nome}  |  Idade: {idade}  | Curso: {curso}  ");
            Console.WriteLine("Adicionado com sucesso!");
            Console.WriteLine("Deseja continuar? 1 - Sim  |  2 - Não\nResposta: ");
            int stop = int.Parse(Console.ReadLine());

            if (stop == 1)
            {
                continue;

            }
            else if (stop == 2) 
            {
                Console.WriteLine("Até Mais!");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }



        }
    }
}

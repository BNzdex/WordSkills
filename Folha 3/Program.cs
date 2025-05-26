using System;

class Aluno
{ 
    static (string[] nome, int[] faltas, int[] nota, int quantidade_cadastros) cadastro_aluno()
    {
        string[] nome = new string[5];
        int[] faltas = new int[5];
        int[] nota = new int[5];

        Console.WriteLine("Deseja cadastrar quantos alunos (de 1 a 5)? ");
        int quantidade_cadastros = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade_cadastros; i++)
        {
            Console.Write($"Digite o nome do {i + 1}° Aluno: ");
            nome[i] = Console.ReadLine();
            Console.Write($"Digite a quantidade de faltas do {i + 1}° Aluno: ");
            faltas[i] = int.Parse(Console.ReadLine());
            Console.Write($"Digite a nota final do {i + 1}° Aluno: ");
            nota[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
        return (nome, faltas, nota, quantidade_cadastros);
        

    }
    static (string[] situacao_nota, string[] situacao_faltas) relatorio(string[] nome, int[] notas, int[] faltas, int quantidade_cadastros)
    {
        string[] situacao_nota = new string[5];
        string[] situacao_faltas = new string[5];

        for (int i = 0; i < quantidade_cadastros; i++)
        {
            Console.WriteLine($"{i + 1}° Aluno: {nome[i]}");

        }

        return (situacao_nota, situacao_faltas);
    }
}

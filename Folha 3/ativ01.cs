using System;
using System.Collections.Generic;

class Aluno
{
    static (List<string> nomes, List<int> faltas, List<int> notas, int quantidadeCadastros) CadastroAluno()
    {
        var nomes = new List<string>();
        var faltas = new List<int>();
        var notas = new List<int>();

        Console.WriteLine("Deseja cadastrar quantos alunos (de 1 a 5)? ");
        int quantidadeCadastros = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeCadastros; i++)
        {
            Console.Write($"Digite o nome do {i + 1}° Aluno: ");
            nomes.Add(Console.ReadLine());

            Console.Write($"Digite a quantidade de faltas do {i + 1}° Aluno: ");
            faltas.Add(int.Parse(Console.ReadLine()));

            Console.Write($"Digite a nota final do {i + 1}° Aluno: ");
            notas.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Aluno cadastrado com sucesso!\n");
        }

        return (nomes, faltas, notas, quantidadeCadastros);
    }

    static (List<string> situacaoNota, List<string> situacaoFaltas, int alunosReprovados) Relatorio(
        List<string> nomes, List<int> notas, List<int> faltas, int quantidadeCadastros)
    {
        var situacaoNota = new List<string>();
        var situacaoFaltas = new List<string>();
        int alunosReprovados = 0;

        for (int i = 0; i < quantidadeCadastros; i++)
        {
            Console.WriteLine($"{i + 1}° Aluno: {nomes[i]}");

            if (notas[i] < 7)
                situacaoNota.Add("Reprovado");
            else
                situacaoNota.Add("Aprovado");

            if (faltas[i] < 5)
                situacaoFaltas.Add("Regular");
            else
                situacaoFaltas.Add("Irregular");

            Console.WriteLine($"Status Nota: {situacaoNota[i]}");
            Console.WriteLine($"Status Faltas: {situacaoFaltas[i]}");

            if (situacaoNota[i] == "Reprovado" || situacaoFaltas[i] == "Irregular")
                alunosReprovados++;
        }

        return (situacaoNota, situacaoFaltas, alunosReprovados);
    }

    static void Main()
    {
        var (nomes, faltas, notas, quantidadeCadastros) = CadastroAluno();
        var (situacaoNota, situacaoFaltas, alunosReprovados) = Relatorio(nomes, notas, faltas, quantidadeCadastros);

        Console.WriteLine($"\nTotal de alunos reprovados: {alunosReprovados}");
    }
}

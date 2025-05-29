using System;
using System.Collections.Generic;

public class Class1
{
    public static List<string> txt = new List<string>();
    public static (List<string> nomes, List<int> faltas, List<int> notas, int quantidadeCadastros) CadastroAluno()
    {
        var nomes = new List<string>();
        var faltas = new List<int>();
        var notas = new List<int>();

        Console.WriteLine("Deseja cadastrar quantos alunos (de 1 a 5)? ");
        int quantidadeCadastros = int.Parse(Console.ReadLine());
        txt.Add($"Quantidade de cadastros: {quantidadeCadastros} alunos\n");

        for (int i = 0; i < quantidadeCadastros; i++)
        {
            Console.Write($"Digite o nome do {i + 1}° Aluno: ");
            nomes.Add(Console.ReadLine());
            txt.Add($"Nome do {1 + i}° aluno: {nomes[i]}");

            Console.Write($"Digite a quantidade de faltas do {i + 1}° Aluno: ");
            faltas.Add(int.Parse(Console.ReadLine()));
            txt.Add($"Faltas do {1 + i}° aluno: {faltas[i]}");

            Console.Write($"Digite a nota final do {i + 1}° Aluno: ");
            notas.Add(int.Parse(Console.ReadLine()));
            txt.Add($"Nota do {1 + i}° aluno: {notas[i]}");

            Console.WriteLine("Aluno cadastrado com sucesso!\n");
            txt.Add("Aluno cadastrado com sucesso!\n");
        }

        return (nomes, faltas, notas, quantidadeCadastros);
    }

    public static (List<string> situacaoNota, List<string> situacaoFaltas, int alunosReprovados) Relatorio(
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
            txt.Add($"\nStatus aluno {i + 1}\nNotas: {situacaoNota[i]}\nFaltas: {situacaoFaltas[i]}");

            if (situacaoNota[i] == "Reprovado" || situacaoFaltas[i] == "Irregular")
                alunosReprovados++;
        }
        txt.Add($"\nTotal de alunos reprovados: {alunosReprovados}");
        return (situacaoNota, situacaoFaltas, alunosReprovados);
    }
}


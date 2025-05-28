using System;
using System.Collections.Generic;
using ativ01;

class Aluno
{
    static void Main()
    {
        var (nomes, faltas, notas, quantidadeCadastros) = Class1.CadastroAluno();
        var (situacaoNota, situacaoFaltas, alunosReprovados) = Class1.Relatorio(nomes, notas, faltas, quantidadeCadastros);

        Console.WriteLine($"\nTotal de alunos reprovados: {alunosReprovados}");
    }
}

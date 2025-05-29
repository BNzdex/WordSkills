using System.IO;
using System.Collections.Generic;

class Aluno
{
    static void Main()
    {
        var (nomes, faltas, notas, quantidadeCadastros) = Class1.CadastroAluno();
        var (situacaoNota, situacaoFaltas, alunosReprovados) = Class1.Relatorio(nomes, notas, faltas, quantidadeCadastros);

        Console.WriteLine($"\nTotal de alunos reprovados: {alunosReprovados}");

        File.WriteAllLines("logAlunos.txt", Class1.txt);
        Console.WriteLine("Histórico da conversa salvo em 'logAlunos.txt'");
    }
}

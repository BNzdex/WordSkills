using System.IO;

class AlunoTXT
{
    static void Main()
    {
        string arquivo = File.ReadAllText ("aluno.txt");
        Console.WriteLine ("Alunos cadastrados: ");
        Console.WriteLine (arquivo);
        
    }
}
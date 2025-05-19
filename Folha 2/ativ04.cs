using System;
using System.IO;

class AlunoTXT
{
    static void Main()
    {
        string arquivo = File.ReadAllText("aluno.txt");
        File.AppendAllText("aluno.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine);
        Console.WriteLine(arquivo);
    }
}

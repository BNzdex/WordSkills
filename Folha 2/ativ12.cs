using System;
using System.IO;
using ClosedXML.Excel;

class Program
{
    static void Main()
    {
        var workbook = new XLWorkbook("Bernardo.xlsx");
        var planilha = workbook.Worksheet("Planilha1");
        var ultimaLinha = planilha.LastRowUsed().RowNumber();

        for (int linha = 2; linha <= ultimaLinha; linha++)
        {
            var nome = planilha.Cell($"A{linha}").Value;
            var idade = planilha.Cell($"B{linha}").Value;
            var curso = planilha.Cell($"C{linha}").Value;

            Console.WriteLine($"Nome: {nome} | Idade: {idade} | Curso: {curso}");
        }
    }
}

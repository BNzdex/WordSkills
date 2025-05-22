using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        var arquivo = File.ReadAllLines("alunos.txt");

        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("Planilha1");

        ws.Cell(1, 1).Value = "Nome";
        ws.Cell(1, 2).Value = "Nota";
        ws.Cell(1, 3).Value = "Situação";
        ws.Cell(1, 4).Value = "Curso";

        for (int i = 0; i < arquivo.Length; i++)
        {
            var colunas = arquivo[i].Split('|');

            string nome = colunas[0].Replace("Nome:", "").Trim();
            string nota = colunas[1].Replace("Nota:", "").Trim();
            string curso = colunas[2].Replace("Curso:", "").Trim();

            int linha = i + 2;

            ws.Cell(linha, 1).Value = nome;
            ws.Cell(linha, 2).Value = double.Parse(nota);
            ws.Cell(linha, 3).FormulaA1 = $"=IF(B{linha}>7,\"Aprovado\",\"Reprovado\")";
            ws.Cell(linha, 4).Value = curso;
        }

        string caminhoPlanilha = "AlunosTXT.xlsx";
        wb.SaveAs(caminhoPlanilha);

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using var pacote = new ExcelPackage(new FileInfo(caminhoPlanilha));
        var planilha = pacote.Workbook.Worksheets[0];

        var grafico = planilha.Drawings.AddChart("graficonotas", eChartType.ColumnClustered);
        grafico.Title.Text = "Gráfico das Notas";
        grafico.Series.Add($"B2:B{arquivo.Length + 1}", $"A2:A{arquivo.Length + 1}");
        grafico.SetPosition(2, 0, 5, 0);
        grafico.SetSize(600, 300);

        pacote.Save();

        Console.WriteLine("Planilha criada com sucesso!");
    }
}

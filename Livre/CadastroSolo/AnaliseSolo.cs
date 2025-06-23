using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class AnaliseSolo
{
    public string NomePropriedade { get; set; }
    public string DataColeta { get; set; }
    public double Ph { get; set; }
    public double Fosforo { get; set; }
    public double Potassio { get; set; }
    public double Magnesio { get; set; }
    public double Calcio { get; set; }
}

public static class CadastroSolo
{
    public static string caminhoArquivo = "AnaliseSolo.json";

    public static List<AnaliseSolo> CarregarAnalises()
    {
        try
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonSerializer.Deserialize<List<AnaliseSolo>>(json) ?? new List<AnaliseSolo>();
            }
        }
        catch 
        {
            Console.WriteLine("Erro ao carregar análises");
        }

        return new List<AnaliseSolo>();
    }

    public static void SalvarAnalises(List<AnaliseSolo> lista)
    {
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminhoArquivo, json);
    }
}

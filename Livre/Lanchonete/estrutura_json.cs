using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
}
public class Pedido
{
    public int Id { get; set; }
    public int Id_cliente { get; set; }
    public List<ItemPedido> Itens { get; set; } = new();
    public double Total => Itens.Sum(i => i.Preco * i.Quantidade);
    public string Data { get; set; }
    public string Status { get; set; }
}
public class ItemPedido
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
}

public class Cardapio
{
    public static List<ItemPedido> Itens = new List<ItemPedido>
    {
    new ItemPedido { Nome = "Hambúrguer", Preco = 20.00, Quantidade = 1 },
    new ItemPedido { Nome = "Batata frita", Preco = 10.00, Quantidade = 1 },
    new ItemPedido { Nome = "Refrigerante", Preco = 5.00, Quantidade = 1 }
    };
}
public class Json() 
{

    GerenciadorDeClientes GClientes = new GerenciadorDeClientes();
    public void SalvarNoArquivo()
    {

        string json = JsonSerializer.Serialize(GClientes.clientes, new JsonSerializerOptions { WriteIndented = true });
        File.AppendAllText(GClientes.caminhoArquivo, json);
    }
    public void CarregarArquivo()
    {
        string json = File.ReadAllText(GClientes.caminhoArquivo);
        var dados = JsonSerializer.Deserialize<List<Cliente>>(json);

        if (dados != null)
        {
            GClientes.clientes = dados;
            if (GClientes.clientes.Count > 0)
                GClientes.ultimoId = GClientes.clientes.Max(c => c.Id);
        }
    }
}

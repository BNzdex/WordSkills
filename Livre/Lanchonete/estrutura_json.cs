using System.Text.Json;
using System.IO;

public class ManipuladorJson
{
    private GerenciadorDeClientes GClientes;
    private GerenciadorDePedidos GPedidos;

    public ManipuladorJson(GerenciadorDeClientes gClientes, GerenciadorDePedidos gPedidos)
    {
        GClientes = gClientes;
        GPedidos = gPedidos;
    }

    public void SalvarNoArquivo()
    {
        string jsonClientes = JsonSerializer.Serialize(GClientes.clientes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(GClientes.caminhoArquivo, jsonClientes);

        string jsonPedidos = JsonSerializer.Serialize(GPedidos.pedidos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(GPedidos.caminho_arquivo, jsonPedidos);
    }

    public void CarregarArquivo()
    {
        if (File.Exists(GClientes.caminhoArquivo))
        {
            string json = File.ReadAllText(GClientes.caminhoArquivo);
            var dados = JsonSerializer.Deserialize<List<Cliente>>(json);
            if (dados != null)
            {
                GClientes.clientes = dados;
                if (dados.Count > 0)
                    GClientes.ultimoId = dados.Max(c => c.Id);
            }
        }

        if (File.Exists(GPedidos.caminho_arquivo))
        {
            string arquivo = File.ReadAllText(GPedidos.caminho_arquivo);
            var dados = JsonSerializer.Deserialize<List<Pedido>>(arquivo);
            if (dados != null)
            {
                GPedidos.pedidos = dados;
                if (dados.Count > 0)
                    GPedidos.ultimoId = dados.Max(c => c.Id);
            }
        }
    }
}

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

public static class Cardapio
{
    public static List<ItemPedido> Itens = new List<ItemPedido>
    {
        new ItemPedido { Nome = "Hambúrguer", Preco = 20.00, Quantidade = 1 },
        new ItemPedido { Nome = "Batata frita", Preco = 10.00, Quantidade = 1 },
        new ItemPedido { Nome = "Refrigerante", Preco = 5.00, Quantidade = 1 }
    };
}

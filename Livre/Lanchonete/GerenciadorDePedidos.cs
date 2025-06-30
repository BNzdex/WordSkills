using System.Text.Json;

public class GerenciadorDePedidos
{
    public List<Pedido> pedidos = new();
    public string caminho_arquivo = "pedidos.json";
    public int ultimoId = 0;
    public GerenciadorDeClientes GerenciadorDeClientes;

    public GerenciadorDePedidos(GerenciadorDeClientes gerenciador)
    {
        GerenciadorDeClientes = gerenciador;
    }

    public void FazerPedido()
    {
        Console.WriteLine("--- Fazendo novo pedido ---");
        Console.WriteLine("Clientes disponíveis: ");
        foreach (var y in GerenciadorDeClientes.clientes)
        {
            Console.WriteLine($"ID: {y.Id} | Nome: {y.Nome}");
        }

        Console.WriteLine("Informe o ID do cliente: ");
        int opcao = int.Parse(Console.ReadLine());
        ultimoId++;

        List<ItemPedido> itensDoPedido = new();

        while (true)
        {
            Console.WriteLine("--- CARDÁPIO ---");
            int b = 1;
            foreach (var y in Cardapio.Itens)
            {
                Console.WriteLine($"{b}. {y.Nome} - R${y.Preco}");
                b++;
            }

            Console.WriteLine("Digite o número do item (0 para finalizar): ");
            int cardapio = int.Parse(Console.ReadLine());

            if (cardapio == 0)
                break;

            var itemSelecionado = Cardapio.Itens[cardapio - 1];
            Console.WriteLine("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            itensDoPedido.Add(new ItemPedido
            {
                Nome = itemSelecionado.Nome,
                Preco = itemSelecionado.Preco,
                Quantidade = quantidade
            });
        }

        string dataFormatada = DateTime.Now.ToString("dd/MM/yyyy");

        Pedido pedido = new Pedido()
        {
            Id = ultimoId,
            Id_cliente = opcao,
            Itens = itensDoPedido,
            Data = dataFormatada,
            Status = "Pendente"
        };

        pedidos.Add(pedido);
        Console.WriteLine($"Pedido adicionado com sucesso!\nTotal : {pedido.Total}");
    }

    public void ListarPedido()
    {
        Console.WriteLine("--- Lista de pedidos ---");
        foreach (var c in pedidos)
        {
            Console.WriteLine($"ID: {c.Id}\nID do cliente: {c.Id_cliente}\nItens: {c.Itens.Count} item(ns)\nTotal: {c.Total}\nData do pedido: {c.Data}\nStatus do pedido: {c.Status}");
        }
    }

    public void FinalizarPedido()
    {
        Console.WriteLine("--- Lista de pedidos ---");
        foreach (var c in pedidos)
        {
            Console.WriteLine($"ID: {c.Id}\nID do cliente: {c.Id_cliente}\nItens: {c.Itens.Count} item(ns)\nTotal: {c.Total}\nData do pedido: {c.Data}\nStatus: {c.Status}");
        }

        Console.WriteLine("Qual o ID do pedido que você deseja finalizar: ");
        int finalizar = int.Parse(Console.ReadLine());

        Pedido pedido = pedidos.Find(c => c.Id == finalizar);
        if (pedido != null)
            pedido.Status = "Concluído";
    }

    public void PuxarHistorico()
    {
        GerenciadorDeClientes.ListarCadastro();
        Console.WriteLine("Qual o ID do cliente que você deseja ver histórico: ");
        int historico = int.Parse(Console.ReadLine());

        List<Pedido> pedido = pedidos.FindAll(c => c.Id_cliente == historico);

        if (pedido.Count > 0)
        {
            Console.WriteLine("--- Lista de pedidos ---");
            foreach (var c in pedido)
            {
                Console.WriteLine($"ID: {c.Id}\nID do cliente: {c.Id_cliente}\nItens: {c.Itens.Count} item(ns)\nTotal: {c.Total}\nData do pedido: {c.Data}\nStatus: {c.Status}");
            }
        }
        else
        {
            Console.WriteLine("Opção inválida, id não correspondente aos nossos registros");
        }
    }
}

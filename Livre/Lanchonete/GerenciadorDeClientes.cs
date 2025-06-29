using System.Text.Json;

public class GerenciadorDeClientes
{
    public List<Cliente> clientes = new();
    public int ultimoId = 0;
    public string caminhoArquivo = "clientes.json";
    Json Json = new Json();

    public GerenciadorDeClientes()
    {
        Json.CarregarArquivo();
    }
    public void AdicionarCliente()
    {
        Console.Clear();
        Console.WriteLine("--- Cadastro De Cliente ---");
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu CPF (ex: 173.973.237-58):");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite seu telefone (ex: 27 99628-3448):");
        string telefone = Console.ReadLine();
        ultimoId++;

        Cliente cliente = new Cliente()
        {
            Id = ultimoId,
            Nome = nome,
            Cpf = cpf,
            Telefone = telefone
        };

        clientes.Add(cliente);
        Json.SalvarNoArquivo();
        Console.WriteLine("Cliente adicionado com sucesso!");
    }
    public void ListarCadastro()
    {
        Console.WriteLine("--- Lista de Clientes ---");
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }
        else
        {
            foreach(var y in clientes)
            {
                Console.WriteLine($"ID: {y.Id}\nNome: {y.Nome}\nCPF: {y.Cpf}\nTelefone: {y.Telefone}");

            }
        }
    }
}

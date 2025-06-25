using System.Text.Json;
using System.Text.Json.Serialization;

public class GerenciadorDeClientes
{
    public List<Cliente> clientes = new();
    private int ultimoId = 0;
    public static string caminhoArquivo = "clientes.json";

    CarregarArquivo();

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
        SalvarNoArquivo();
        Console.WriteLine("Cliente adicionado com sucesso!");
    }
    public void ListarCadastro()
    {

    }
}
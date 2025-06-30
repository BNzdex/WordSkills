using System;
using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            var gerenciadorDeClientes = new GerenciadorDeClientes();
            var gerenciadorDePedidos = new GerenciadorDePedidos(gerenciadorDeClientes);
            var manipuladorJson = new ManipuladorJson(gerenciadorDeClientes, gerenciadorDePedidos);

            manipuladorJson.SalvarNoArquivo();
            manipuladorJson.CarregarArquivo();

            Console.WriteLine("--- MENU PRINCIPAL ---");
            Console.WriteLine("1. Cadastrar cliente");
            Console.WriteLine("2. Fazer novo pedido");
            Console.WriteLine("3. Listar pedidos");
            Console.WriteLine("4. Listar clientes");
            Console.WriteLine("5. Finalizar pedido");
            Console.WriteLine("6. Histórico de pedidos por cliente");
            Console.WriteLine("7. Sair so sistema");
            Console.WriteLine("O que deseja fazer? ");
            string opcao = Console.ReadLine();


            if (opcao.ToUpper().Contains("CADASTRAR") || opcao == "1")
            {
                gerenciadorDeClientes.AdicionarCliente();
            }
            else if (opcao.ToUpper().Contains("FAZER") || opcao == "2")
            {
                gerenciadorDePedidos.FazerPedido();
            }
            else if (opcao.ToUpper().Contains("LISTAR P") || opcao == "3")
            {
                gerenciadorDePedidos.ListarPedido();
            }
            else if (opcao.ToUpper().Contains("LISTAR C") || opcao == "4")
            {
                gerenciadorDeClientes.ListarCadastro();
            }
            else if (opcao.ToUpper().Contains("FINALIZAR") || opcao == "5")
            {
                gerenciadorDePedidos.FinalizarPedido();
            }
            else if (opcao.ToUpper().Contains("HISTÓRICO") || opcao == "6")
            {
                gerenciadorDePedidos.PuxarHistorico();
            }
            else if (opcao.ToUpper().Contains("SAIR") || opcao == "7")
            {
                manipuladorJson.SalvarNoArquivo();
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }

        }
    }
}








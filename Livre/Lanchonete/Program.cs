using System;
using System.ComponentModel;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            var GerenciadorDeClientes = new GerenciadorDeClientes();

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
                GerenciadorDeClientes.AdicionarCliente();
            }
            else if (opcao.ToUpper().Contains("FAZER") || opcao == "2")
            {
                Console.WriteLine("Aplicar função para solocitar pedido");
            }
            else if (opcao.ToUpper().Contains("LISTAR P") || opcao == "3")
            {
                Console.WriteLine("Aplicar função para listar pedidos");
            }
            else if (opcao.ToUpper().Contains("LISTAR C") || opcao == "4")
            {
                GerenciadorDeClientes.ListarCadastro();
            }
            else if (opcao.ToUpper().Contains("FINALIZAR") || opcao == "5")
            {
                Console.WriteLine("Aplicar função para finalizar pedido");
            }
            else if (opcao.ToUpper().Contains("HISTÓRICO") || opcao == "6")
            {
                Console.WriteLine("Aplicar função para puxar historico do cliente");
            }
            else if (opcao.ToUpper().Contains("SAIR") || opcao == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }

        }
    }
}










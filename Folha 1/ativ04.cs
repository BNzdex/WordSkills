using System;

class Program {
    static void Main() {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite sua nota: ");
        int nota = int.Parse(Console.ReadLine());
        
        if (nota >= 7){
            Console.WriteLine($"Parabéns {nome}, você foi aprovado");
        }
        else {
            Console.WriteLine($"Lamento informar {nome}, que infelizmente você foi reprovado");
        }
    }     
 }
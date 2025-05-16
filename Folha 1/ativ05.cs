using System;

class Program {
    static void Main() {
        
        for (int y = 1; y <= 10; y++){
            
            Console.WriteLine($"{y}");
        }
        Console.WriteLine("\n========== Agora com while ==========\n");
        
        int n1 = 1;
        while (n1 < 11){
            Console.WriteLine(n1);
            n1 += 1;
        }
        Console.WriteLine("\n========== Segunda parte da atividade ==========\n");
        int soma = 0;
        for (int i = 1; i < 101; i++){
            soma += i;
        }
        Console.WriteLine($"A soma dos números de 1 a 100 é {soma}");
        
    }     
 }

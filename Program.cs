using System;

class Program {
    static void Main(string[] args) {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE) {
            K = K + 1;
            SOMA = SOMA + K;
        }
        Console.WriteLine("Resposta 1: ");
        Console.WriteLine(SOMA);
        Console.WriteLine();


        Console.WriteLine("Resposta 2: ");
        int num = 21;

        int numero1 = 0;
        int numero2 = 1;

        while (numero2 <= num) {
            if (numero2 == num) {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci!");
                break;
            }

            int numero3 = numero1 + numero2;
            numero1 = numero2;
            numero2 = numero3;
        }
        if (numero2 > num) {
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
        Console.WriteLine();

        Console.WriteLine(@"3) Descubra a lógica e complete o próximo elemento:  

   

        a) 1, 3, 5, 7, ___  

        b) 2, 4, 8, 16, 32, 64, ____  

        c) 0, 1, 4, 9, 16, 25, 36, ____  

        d) 4, 16, 36, 64, ____  

        e) 1, 1, 2, 3, 5, 8, ____  

        f) 2,10, 12, 16, 17, 18, 19, ____  ");

        Console.WriteLine(@"Resposta 3:
        a)9
        b)128
        c)49
        d)100
        e)13
        f)200");
        Console.WriteLine();
        
        Console.WriteLine(@"Resposta 4:
        considerando que em 30 minutos o caminhão percorreria 55Km e o carro 40km.
        descontando 10 minutos do caminhão (5 de cada pedágio)
        ao longo de do percurso o após 30 minutos o caminhão teria percorrido 45Km e o 40Km.
        logo, mantendo a velocidade do percurso o caminhão estará mais proximo.
        eles se cruzam aproximadamente 33 minutos pós o inicio do trageto.
         ");
        
        Console.WriteLine("Resposta 5:");

        string original = "hello world";
        Console.WriteLine("Original: " + original);

        var chars = original.ToCharArray();
        int length = chars.Length;

        for (int i = 0; i < length / 2; i++) {
            var temp = chars[i];
            chars[i] = chars[length - 1 - i];
            chars[length - 1 - i] = temp;
        }

        string reversed = new string(chars);
        Console.WriteLine("Reversed: " + reversed);

    }
}


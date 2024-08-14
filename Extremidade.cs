// Leia 2 valores inteiros e armazene-os nas variáveis A e B.
// Efetue a soma de A e B atribuindo o seu resultado na variável X.

using System;

class URI {
    static void Main(string[] args) { 
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int X = A + B;

        Console.WriteLine("X = " + X);
    }
}

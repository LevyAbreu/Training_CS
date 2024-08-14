// A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
// Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

using System;

class URI {
    static void Main(string[] args) { 

        // Leia o valor do raio (double)
        double raio = double.Parse(Console.ReadLine());

        // Defina o valor de π
        double pi = 3.14159;

        // Calcule a área da circunferência
        double area = pi * Math.Pow(raio, 2);

        // Imprima a saída no formato especificado
        Console.WriteLine("A=" + area.ToString("F4"));
    }

}

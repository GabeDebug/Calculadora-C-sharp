using System;
namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Soma();
        }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine()); 
            
        Console.WriteLine("Digite o Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma é {resultado} ");
    } 
    }
}
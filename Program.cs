using System;
namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("1 -  Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 -  Divizão ");
            Console.WriteLine("4 - Multiplicacão ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Divizao();
                    break;
                case 4: Multiplicacao();
                    break;
                default: Menu();
                    break;
            }
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

        static void Subtracao()
        {
        Console.Clear();

        Console.WriteLine("Digite o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o  segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1-v2;
        Console.WriteLine($"o Resultado da Subtracao: {resultado}");
        }

        static void Divizao()
        {
        Console.Clear();
        
        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divizão: {resultado}");
    }

        static void Multiplicacao()
        {
        Console.Clear();

        Console.WriteLine("digite um valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("digite outro valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;
        Console.WriteLine($"o Resultado da multiplicacao: {resultado}");
        }
    }
}
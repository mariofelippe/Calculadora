using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada;
            float primeiroValor;
            float segundoValor;
            float resultado;
            string op;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("***********************************************");
                Console.WriteLine("*             Calculadora Simples             *");
                Console.WriteLine("***********************************************");
                Console.WriteLine();
                Console.WriteLine("1 - Adição.");
                Console.WriteLine("2 - Subtração.");
                Console.WriteLine("3 - Multiplicação.");
                Console.WriteLine("4 - Divisão.");
                Console.WriteLine("99 - Sair.\n");
                Console.Write("Opção: ");
                op = Console.ReadLine();

                if (op == "1")
                {
                   
                    Console.Write("Primeiro Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out primeiroValor);
                    Console.Write("Segundo Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out segundoValor);

                    resultado = primeiroValor + segundoValor;
                    Console.WriteLine("O Resultado é: " + resultado);
                    Console.Write("Apreter para continuar...");
                    Console.ReadKey();

                } else if (op == "2")
                {
                    
                    Console.Write("Primeiro Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out primeiroValor);
                    Console.Write("Segundo Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out segundoValor);

                    resultado = primeiroValor - segundoValor;
                    Console.WriteLine("O Resultado é: " + resultado);
                    Console.Write("Apreter para continuar...");
                    Console.ReadKey();

                } else if (op == "3")
                {
                    
                    Console.Write("Primeiro Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out primeiroValor);
                    Console.Write("Segundo Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out segundoValor);

                    resultado = primeiroValor * segundoValor;
                    Console.WriteLine("O Resultado é: " + resultado);
                    Console.Write("Apreter para continuar...");
                    Console.ReadKey();

                } else if (op == "4")

                {
                    
                    Console.Write("Primeiro Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out primeiroValor);
                    Console.Write("Segundo Valor: ");
                    entrada = Console.ReadLine().Trim();
                    float.TryParse(entrada, out segundoValor);

                    resultado = primeiroValor / segundoValor;
                    Console.WriteLine("O Resultado é: " + resultado);
                    Console.Write("Apreter para continuar...");
                    Console.ReadKey();

                } else if (op == "99")
                {
                    break;
                } else
                {
                    Console.Write("Opção Inválida!");
                    Console.ReadKey();
                }

               
            }


        }
    }
}

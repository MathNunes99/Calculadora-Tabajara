using System;

namespace Calculadora_Tabajara.ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string opcao = "";
            
            while (opcao != "s")
            {
                int valor1 = 0;
                int valor2 = 0;
                int resultado = 0;

                TelaMenuInicial();

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s")
                {
                    Console.WriteLine("Digite um valor correto");
                    opcao = Console.ReadLine();
                }

                Console.WriteLine("Digite o valor 1");
                int.TryParse(Console.ReadLine(), out valor1);
                Console.WriteLine("Digite o valor 2");
                int.TryParse(Console.ReadLine(), out valor2);

                switch (opcao)
                {
                    case "1":
                        resultado = valor1 + valor2;
                        break;
                    case "2":
                        resultado = valor1 - valor2;
                        break;
                    case "3":
                        resultado = valor1 * valor2;
                        break;
                    case "4":
                        if (valor2 <= 0)
                        {
                            Console.WriteLine("O valor 2 não pode ser negativo");
                            Console.ReadKey();
                        }
                        else                        
                            resultado = valor1 / valor2;
                        
                        break;
                }
                if (opcao == "4" && resultado == 0)
                {
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("R:" + resultado);
                Console.ReadKey();
                Console.Clear();

            }


        }

        private static void TelaMenuInicial()
        {
            Console.WriteLine("Bem-Vindo a Calculadora Tabajara");
            Console.WriteLine();
            Console.WriteLine("Digite '1' para SOMAR");
            Console.WriteLine("Digite '2' para SUBTRAIR");
            Console.WriteLine("Digite '3' para MULTIPLICAR");
            Console.WriteLine("Digite '4' para DIVIDIR");
        }
    }
}

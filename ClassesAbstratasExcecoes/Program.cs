using System;

namespace ClassesAbstratasExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
 
            

            try
            {

                Console.Write("Digite o primeiro número: ");
                decimal primeiro = decimal.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                decimal segundo = decimal.Parse(Console.ReadLine());

                FuncionalCalculadora calculadora = new FuncionalCalculadora(primeiro, segundo);

                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir\n");
                Console.WriteLine("Digite sua opção: ");
                int opcao = int.Parse(Console.ReadLine());


                Console.WriteLine("Resultado: ");
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{calculadora.Soma():F2}");
                        break;

                    case 2:
                        Console.WriteLine($"{calculadora.Subtracao():F2}");
                        break;

                    case 3:
                        Console.WriteLine($"{calculadora.Multiplicacao():F2}");
                        break;

                    case 4:
                        Console.WriteLine($"{calculadora.Divisao():F2}");
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Primeira lei da matemática... Não dividirás por zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número corretamente...");
            }

        }
    }
}

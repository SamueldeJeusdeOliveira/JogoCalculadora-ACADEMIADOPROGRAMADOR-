using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-------------------------");
            bool t = true;
            try
            {
                while (t == true)
                {

                    Console.WriteLine("Digite uma opção:");
                    Console.WriteLine("[1] Soma\n[2] Subrair\n[3] Multiplicação\n[4] Divisão\n[5] Sair");
                    int opcao = int.Parse(Console.ReadLine());
                    while (!(opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4 || opcao == 5))
                    {
                        Console.Write("Digite uma opção válida! ");
                        opcao = int.Parse(Console.ReadLine());
                    }
                    if (opcao == 5)
                    {
                        break;
                    }
                    
                    Console.WriteLine("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    if(opcao == 4 && n1 == 0)
                    {
                        while (n1 == 0)
                        {
                            Console.WriteLine("Não é permitido divisão com zero! Por favor digite novamente!");
                            n1 = double.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Digite o segundo número:");
                    double n2 = double.Parse(Console.ReadLine());
                    if (opcao == 4 && n2 == 0)
                    {
                        while (n2 == 0)
                        {
                            Console.WriteLine("Não é permitido divisão com zero! Por favor digite novamente!");
                            n2 = double.Parse(Console.ReadLine());
                        }
                    }
                    double resultado = 0;

                    switch (opcao)
                    {
                        case 1:
                            resultado = n1 + n2;
                            break;
                        case 2:
                            resultado = n1 - n2;
                            break;
                        case 3:
                            resultado = n1 * n2;
                            break;
                        default:
                            resultado = n1 / n2;
                            break;
                    }
                    Console.Clear();

                    Console.WriteLine($"Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

                    Console.WriteLine("------------------------------------------------------------------------------");
                }
                Console.WriteLine("Você saiu do Jogo!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Um erro aconteceu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

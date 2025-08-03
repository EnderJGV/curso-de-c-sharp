namespace Aula10
{
    public class Program
    {
        public static void Main()
        {
            bool varContinue = true;

            while (varContinue)
            {
                //Iniciando o programa
                Console.WriteLine("========= Calculadora Simples =========");
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                //Selecionar o tipo de operação
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1. Adição (+)");
                Console.WriteLine("2. Substração (-)");
                Console.WriteLine("3. Multiplicação (*)");
                Console.WriteLine("4. Divisão (/)");
                Console.WriteLine("Digite o número da sua operação: ");
                int operacao = Convert.ToInt32(Console.ReadLine());

                double resultado = 0;

                //Condições
                if (operacao == 1)
                {
                    resultado = num1 + num2;
                }
                else if (operacao == 2)
                {
                    resultado = num1 - num2;
                }
                else if (operacao == 3)
                {
                    resultado = num1 * num2;
                }
                else if (operacao == 4)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                }
                else
                {
                    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
                }

                Console.WriteLine("Resultado = " + resultado);

                Console.WriteLine("\nDeseja continuar calculando? (s/n): ");
                string repsUser = Console.ReadLine();

                if (repsUser == "s")
                {
                    varContinue = true;
                }
                else if (repsUser == "n")
                {
                    Console.WriteLine("Obrigado por Usar a calculadora");
                    varContinue = false;
                }
            }
        }
    }
}

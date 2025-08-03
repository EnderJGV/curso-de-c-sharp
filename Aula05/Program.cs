namespace Aula05
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("========= Calculadora Bem Simples =========");
            Console.WriteLine("Digite o primeiro número:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number2 - number1;
            int multiplication = number1 * number2;
            int division = number2 / number1;
            int module = number2 % number1;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(module);
        }
}
}

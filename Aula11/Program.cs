namespace Aula11
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número de 1 a 7: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("O dia da sema e Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("O dia da sema e Terça-Feira");
                    break; 
                case 3:
                    Console.WriteLine("O dia da sema e Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("O dia da sema e Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("O dia da sema e Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("O dia da sema e Sábado");
                    break;
                case 7:
                    Console.WriteLine("O dia da sema e Domingo");
                    break;
            }
        }
    }
}

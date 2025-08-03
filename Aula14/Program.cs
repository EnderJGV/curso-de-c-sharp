namespace Aula14;

public class Program
{
    public static void Main()
    {
        /*
            for (codição 1; codição 2; codição 3)
            {
                Bloco de código
            }
         */

        //Ex: 1
        //for (int i = 1;i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //Ex: 2
        for(int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,10}");
            }
            Console.WriteLine();
        }
    }
}

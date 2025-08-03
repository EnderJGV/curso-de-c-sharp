namespace Aula16;

public class Program
{
    public static void Main()
    {
        // Declarando um array de strings
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Exibindo os elementos do array
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Contagem de indices
        Console.WriteLine($"Total de frutas: {fruits.Length}");

        // Alterar valores
        Console.WriteLine("Alterando o valor da fruta no índice 2...");
        fruits[2] = "Coconut";
        Console.WriteLine($"Fruta no índice 2 agora é: {fruits[2]}");


    }
}

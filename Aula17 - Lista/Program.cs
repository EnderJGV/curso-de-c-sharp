namespace Aula17;

public class Program
{
    public static void Main()
    {
        List<string> fruits = new List<string>() 
        { 
            "Apple",
            "Banana",
            "Cherry",
        };

        Console.WriteLine(fruits[2]);

        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Limão");
        fruits.Add("Melancia");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Remove("Banana");
    }
}

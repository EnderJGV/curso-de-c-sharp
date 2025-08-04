namespace Aula22;

public class Program
{
    public static void Main()
    {
        // 1. Instanciar um objeto do tipo Cake
        var cakeStrawberry = new Cake();

        // 2. Atribuir valores aos atributos do objeto
        cakeStrawberry.Id = 1;
        cakeStrawberry.Name = "Bolo de Morango";
        cakeStrawberry.Description = "Bolo de morango com cobertura de chantilly";
        cakeStrawberry.Value = 25.50m;
        cakeStrawberry.IsFilling = true;

        Console.WriteLine($"Id: {cakeStrawberry.Id}");
        Console.WriteLine($"Name: {cakeStrawberry.Name}");
        Console.WriteLine($"Description: {cakeStrawberry.Description}");
        Console.WriteLine($"Value: {cakeStrawberry.Value:C}");
        Console.WriteLine($"Is Filling: {cakeStrawberry.IsFilling}");
    }
}
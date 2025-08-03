namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======= Cadastro de Usuário =======");

        // Solicitar o nome do usuário
        Console.WriteLine("Digite o seu nome:");
        string name = Console.ReadLine();

        // Solicitar a Idade do usuário
        Console.WriteLine("Digite a sua idade:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("======= Dados do Usuário =======");
        // Exibir os dados do usuário  
        Console.WriteLine("Nome : " + name);
        Console.WriteLine("Idade: " + age);


    }
}

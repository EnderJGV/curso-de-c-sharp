namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"C:\Curso-dotnet\Aula19 - Gerenciador de Lista de Compras\";
        string fileName = "ListaCompras.txt";

        string filePath = path + fileName;

        List<string> shoopingList = new List<string>();

        //Logica
        if (File.Exists(filePath))
        {
            shoopingList.AddRange(File.ReadAllLines(filePath));
        }

        bool condition = true;

        while (condition)
        {
            Console.WriteLine("\n=========== Lista de Compras ===========");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Listar itens");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("\nDigite a opção desejada: ");

            string choiceUser = Console.ReadLine();

            switch(choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o item que deseja adicionar: ");
                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoopingList.Add(itemInsert);
                        Console.WriteLine($"O item '{itemInsert}' foi adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o item que deseja remover: ");
                    string itemRemove = Console.ReadLine();

                    if (shoopingList.Remove(itemRemove))
                    {
                        Console.WriteLine($"O item '{itemRemove}' foi removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"O item '{itemRemove}' não foi encontrado na lista.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Itens da sua lista de compras: ");
                    if(shoopingList.Count > 0)
                    {
                        foreach(string item in shoopingList)
                        {
                            Console.WriteLine($"- {item}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista esta Vazia");
                    }
                        break;
                case "4":
                    File.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}
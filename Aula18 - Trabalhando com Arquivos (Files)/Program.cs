namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. Criando um arquivo
        //File.WriteAllText("file.txt","Hello Word!");

        //Console.WriteLine("Arquivo criado com sucesso!");

        // 2. Criando em um diretório específico
        //string directoryPath = @"C:\Curso-dotnet\Aula18 - Trabalhando com Arquivos (Files)\fileName.txt";
        //string content = "Hello World";
        //File.WriteAllText(directoryPath, content);

        // 3. Criando um arquivo Word
        //string directoryPath = @"C:\Curso-dotnet\Aula18 - Trabalhando com Arquivos (Files)\";
        //string fileName = "myDocument.Doc";
        //string filePath = directoryPath + fileName;

        //string content = "Hello World";

        //File.WriteAllText(filePath, content);

        //Console.WriteLine("Arquivo Word criado com sucesso!");

        // 4. inserir um texto em um arquivo existente
        string directoryPath = @"C:\Curso-dotnet\Aula18 - Trabalhando com Arquivos (Files)\";
        string fileName = "myDocument.Doc";
        string filePath = directoryPath + fileName;

        string additionalContent = "| Curso de C# e .NET";

        File.AppendAllText(filePath, additionalContent);

        Console.WriteLine("Arquivo Word atualizado com sucesso!");


    }
}

// int numero = 10;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
// }

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }


// int soma = 0, numero = 0;

// do
// {
//     Console.Write("Digite um número (0 para sair): ");
//     numero = int.Parse(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");


string opcao;

while (true)
{
    Console.Clear();
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando cliente...");
            // Lógica de cadastro
            break;
        case "2":
            Console.WriteLine("Buscando cliente...");
            // Lógica de busca
            break;
        case "3":
            Console.WriteLine("Apagando cliente...");
            // Lógica de apagar
            break;
        case "4":
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0); // Encerra o programa
            break; // Encerra o loop e o programa
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}
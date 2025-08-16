// (int, string, string, decimal) tupla = (1, "Pedro", "Machado", 1.80m); // Maneita mais recomendada seria esta
// // ValueTuple<int, string, string> outroExemploTupla = (1, "Pepe", "Machado");
// // var outroExemploTupleCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80m);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

using Tuplas_na_pratica.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _quantidadeDeLinas) = arquivo.LerArquivo("Arquivo/arquivo.txt");

if (sucesso)
{
    foreach (string linhas in linhasArquivo)
    {
        Console.WriteLine(linhas);
    }
}
else
{
    Console.WriteLine("Erro ao ler arquivo");
}

Console.WriteLine("----------------OPERADOR TERNARIO----------------");

int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine("O numero e par?" + (ehPar ? "SIM" : "NAO"));
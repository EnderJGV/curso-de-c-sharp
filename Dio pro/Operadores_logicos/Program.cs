// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"E possivel realizar a compra? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada com sucesso");
    quantidadeEmEstoque -= quantidadeCompra;
    Console.WriteLine($"Quantidade em estoque atualizada: {quantidadeEmEstoque}");
}
else
{
    Console.WriteLine("Nao ha estoque suficiente para realizar a venda");
}
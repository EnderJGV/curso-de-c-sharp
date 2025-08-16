using Nuget.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material de Escritorio", 25.0m, dataAtual);
Vendas v2 = new Vendas(2, "Lincença de Software", 110.0m, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivo/vendas.json", serializado);

Console.WriteLine(serializado);


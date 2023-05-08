using Algoritmos;

var lista = new List<int> { };
for (var i = 1; i<= 100; i++)
{
    lista.Add(i);
}

Console.WriteLine("Digite o número que deseja buscar da lista: ");
var item = Convert.ToInt32(Console.ReadLine());

var listaConcatenada = String.Join(",", lista);
Console.WriteLine($"\nLista: [{listaConcatenada}]\n");

var busca = new Busca();
var resultado = busca.BuscaBinaria(lista, item);

if (resultado == null)
{
    Console.WriteLine($"\nNúmero {item} não encontrado."); 
    return;
}

Console.WriteLine($"\nNúmero {resultado} encontrado com {busca.Contador} tentativas.");



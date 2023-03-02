using System.Globalization;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Entre com seu nome completo");
string fullName = Console.ReadLine();
Console.WriteLine("Quantos quartos tem sua casa?");
int bedrooms = int.Parse(Console.ReadLine());
Console.WriteLine("Entre product price");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string lastName = vet[0];
int age = int.Parse(vet[1]);
double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine($"Seu nome Completo: {fullName} \n");
Console.WriteLine($"Quantidades de quartos: {bedrooms} \n");
Console.WriteLine($"Valor do Imovel: R$ {price} \n");
Console.WriteLine($"Ultimo nome: {lastName}\n");
Console.WriteLine($"Sua idade: {age} anos \n");
Console.WriteLine($"Sua altura: {height} metros");
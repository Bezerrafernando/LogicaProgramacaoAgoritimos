// See https://aka.ms/new-console-template for more information
Console.Clear();

int x, y, z;

string[] vetor = Console.ReadLine().Split(' ');

x = int.Parse(vetor[0]);
y = int.Parse(vetor[1]);
z = int.Parse(vetor[2]);

if(x < y && x < z){
    Console.WriteLine($"MENOR = {x}");
}
else if (y < z){
    Console.WriteLine($"MENOR = {y}");
}
else {
    Console.WriteLine($"MENOR = {z}");
}
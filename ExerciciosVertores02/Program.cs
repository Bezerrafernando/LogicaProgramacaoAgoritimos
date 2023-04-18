// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int N = int.Parse(Console.ReadLine());

int[] vetor = new int[N];

string[] valores = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++){
    vetor[i] = int.Parse(valores[i]);
}
// 1: mostrando os numeros pares
for (int i = 0; i < N; i++){
    if(vetor[i] % 2 == 0){
        Console.Write(vetor[i]+ " ");
    }
} 
Console.WriteLine();

// 2: mostrando a quantidades de pares
int quantidadePares = 0;
for(int i = 0; i < N; i++){
    if (vetor[i] % 2 == 0){
        quantidadePares++;
    }
}
Console.WriteLine(quantidadePares);
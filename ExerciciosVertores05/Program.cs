// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int N = int.Parse(Console.ReadLine());


double[] vetor = new double[N];

string[] valores = Console.ReadLine().Split(' ');
for(int i = 0; i < N; i++){
    vetor[i] = double.Parse(valores[i]);
}
double somDosParses = 0.0;
int quantidadeDePares = 0;
for (int i = 0; i < N; i++){
    if(vetor[i] % 2 == 0){
        somDosParses = somDosParses + vetor[i];
        quantidadeDePares++;
    }
}
if (quantidadeDePares == 0){
    Console.WriteLine("Não havia nenhum numero par");
}
else{
    double media = somDosParses / quantidadeDePares;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
using System.Globalization;
// See https://aka.ms/new-console-template for more information
Console.Clear();

int N = int.Parse(Console.ReadLine());
double[] vetor = new double[N];
string[] valores = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++){
    vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
}

// 1: calculando e mostrando a media
double soma = 0.0;
for(int i = 0; i < N; i++){
    soma = soma + vetor[i];
}
double media = soma / N;
Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

// 2: mostrando todos elementos abaixo da media
for (int i = 0; i < N; i++){
    if(vetor[i] < media){
        Console.WriteLine(vetor[i].ToString("F1", CultureInfo.InvariantCulture));
    }
}

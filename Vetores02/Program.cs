﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int N;
double[] A;
N = int.Parse(Console.ReadLine());
A = new double[N];

string[] s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

}
for (int i = 0; i < N; i++)
{
    Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");

}
Console.WriteLine();

double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma = soma + A[i];
}
double media = soma / N;

Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString ("F2", CultureInfo.InvariantCulture));

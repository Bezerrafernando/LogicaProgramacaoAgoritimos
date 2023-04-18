// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int N = int.Parse(Console.ReadLine());

double[] alturas = new double[N];
char[] sexos = new char[N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
    sexos[i] = char.Parse(valores[1]);
}
// 2: menos altura
double menorAltura = alturas[0];
for (int i = 0; i < N; i++)
{
    if (alturas[i] < menorAltura)
    {
        menorAltura = alturas[i];
    }
}
Console.WriteLine("Maior altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

// 3: altura media das mulheres
double somaDasAlturasDasMulheres = 0.0;
int contMulheres = 0;
for (int i = 0; i < N; i++)
{
    if (sexos[i] == 'F')
    {
        somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + alturas[i];
        contMulheres++;
    }
}
if (contMulheres == 0)
{
    Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
}
else
{
    double media = somaDasAlturasDasMulheres / contMulheres;
    Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
}
// 4: numeros de homens
int contHomens = 0;
for (int i = 0; i < N; i++) {
    if (sexos[i] == 'M')
    {
        contHomens++;
    }
}
Console.WriteLine("Numeros de homens = " + contHomens);


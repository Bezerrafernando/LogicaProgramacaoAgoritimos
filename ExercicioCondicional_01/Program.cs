// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

double nota1, nota2, soma;

nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

soma = nota1 + nota2;

Console.WriteLine("NOTA FINAL = " + soma.ToString("F1" , CultureInfo.InvariantCulture));

if ( soma >= 60.0){
    Console.WriteLine("APROVADO");
}
else if ( soma < 60.0){
    Console.WriteLine("REPROVADO");
}
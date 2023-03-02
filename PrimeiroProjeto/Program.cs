using System;
using System.Globalization;

namespace ConsoleAplication2{
    class Program
    {
        static void Main(string[]agrs){
          double x = 10.35784;
          int y = 32;
          string z = "Dbezerra";
          char w  = 'D';

          Console.WriteLine("Olá Mundo");
          Console.WriteLine("BOm dia");
          Console.WriteLine("Até mais tarde");

          Console.WriteLine();
          Console.WriteLine(x.ToString("F2"));
          Console.WriteLine(x.ToString("F4"));
          Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
          Console.WriteLine();
          Console.WriteLine("RESULTADO = " + x);
          Console.WriteLine("O valor do troco é " + x + " reais");
          Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
          Console.WriteLine();
          Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
          Console.ReadLine();


        }
    }
}
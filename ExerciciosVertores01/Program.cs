using System;
using System.Globalization;

namespace vetor1{
    class Program{
        static void Main(string[]agrs){
            Console.Clear();

            int N = int.Parse(Console.ReadLine());
            double[] vertor = new double[N];
            string[] valores = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++){
                vertor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            } 
            double maior = vertor[0];
            int posicaoMaior = 0;

            for(int i = 1; i < N; i++){
                if ( vertor[i] > maior){
                    maior = vertor[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}
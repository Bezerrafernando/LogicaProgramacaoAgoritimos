// See https://aka.ms/new-console-template for more information
Console.Clear();

int N;
int[] vet;

N = int.Parse(Console.ReadLine());
vet = new int[N];
string[] s = Console.ReadLine().Split(' ');
for(int i=0; i < N; i++){
    vet[i] = int.Parse(s[i]);
}
for(int i = 0; i < N; i++){
    if(vet[i] < 0){
        Console.WriteLine(vet[i]);
    }
}
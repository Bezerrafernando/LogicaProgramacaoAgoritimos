// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Deus é Bom todo tempo!!!");

int senha = int.Parse(Console.ReadLine());

while(senha != 2002){
    Console.WriteLine("Senha invalida");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");
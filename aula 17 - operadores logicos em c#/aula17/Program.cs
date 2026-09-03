Console.WriteLine("Escreva as notas: ");
int n1 = int.Parse(Console.ReadLine);
int n2 = int.Parse(Console.ReadLine);
int n3 = int.Parse(Console.ReadLine);
int n4 = int.Parse(Console.ReadLine);

int media = (n1 + n2+ n3 + n4) / 4;

Console.WriteLine("Está de recuperação: ");
Console.WriteLine((media > 3) && (media < 6));


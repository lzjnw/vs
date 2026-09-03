// if(condicao)
// {
//     //instrucao
// }
// else
// {
//     //instrucao
// }

//EXEMPLO 1

// Console.WriteLine("Informe os numeros: ");
// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());

// if(n1 > n2)
// {
//     Console.WriteLine("O primeiro é maior");
// }
// else
// {
//     Console.WriteLine("O segundo é maior");
// }


// EXEMPLO 2

// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());
// int n4 = int.Parse(Console.ReadLine());

// double media = (n1 + n2 + n3 + n4) / 4;

// if(media > 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }


// EXEMPLO 3

// Console.Write("Digite o valor que deseja sacar: ");
// int saque = int.Parse(Console.ReadLine());
// int vd = 1000;

// if(saque <= 1000)
// {
// int va = vd - saque;
// Console.Write("O saque foi realizado! Seu novo saldo é de: ");
// Console.WriteLine(va);

// }
// else
// {
//     Console.WriteLine("Seu saldo é insuficiente!");
// }


// EXEMPLO 3


// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());
// int n4 = int.Parse(Console.ReadLine());

// double media = (n1 + n2 + n3 + n4) / 4;

// if (media >= 7)
// {
//     Console.WriteLine("APROVADO!!");
// }
// else
// {
//     if (media < 4)
//     {
//         Console.WriteLine("REPROVADO!");
//     }
//     else
//     {
//         Console.WriteLine("RECUPERAÇÃO!");
//     }
// }


// DESAFIO 1

// Console.WriteLine("Escreva o número: ");
// int n1 = int.Parse(Console.ReadLine());


// if(n1 % 5 == 0)
// {
//     Console.WriteLine("Este número é divisivel por 5.");
// }
// else
// {
//     Console.WriteLine("Este número não é divisivel por 5.");
// }


// DESAFIO 2

// using System.Runtime.InteropServices.Marshalling;

// Console.WriteLine("Insira os números: ");
// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());

// Console.Write("O menor número é: ");

// if (n1 < n2 && n1 < n3)
// {
//     Console.WriteLine(n1);
// }
// else
// {
//     if (n2 < n1 && n2 < n3)
//     {
//         Console.WriteLine(n2);
//     }

//     else
//     {
//         Console.WriteLine(n3);
//     }
// }



// DESAFIO 4

using System.Data.SqlTypes;

Console.Write("Insira o valor do seu salário: ");
int sb = int.Parse(Console.ReadLine());

if(sb <= 500)
{
    double snovo = sb * 1.10;
    Console.WriteLine("Seu novo salario é de: " + snovo);
}
else
{
   Console.WriteLine("Sem aumento.");    
}


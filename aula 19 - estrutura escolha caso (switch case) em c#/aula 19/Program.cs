// Console.WriteLine("Informe a classe do funcionário (a, b ou c)");
// string cla = Console.ReadLine();

// Console.WriteLine("Informe o salário");
// double sal = double.Parse(Console.ReadLine());
// double nsal = 0;

// switch(cla)
// {
//     case "a":
//     nsal = sal + (sal * 0.10);

//     break;

//     case "b":
// nsal = sal + (sal * 0.15);

//     break;

//     case "c":
// nsal = sal + (sal * 0.20);

//     break;

//     default:
//     Console.WriteLine("Classe nao existe!");
//     break;
// }

// Console.WriteLine("Novo salário " + nsal);


// DESAFIO 01

// Console.WriteLine("Informe o primeiro número");
// int n1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Informe o segundo número");
// int n2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Informe o operador");
// string op = (Console.ReadLine());

// int res = 0;

// switch (op)
// {
//     case "+":
//         res = n1 + n2;
//         break;

//     case "-":
//         res = n1 - n2;
//         break;

//             case "*":
//         res = n1 * n2;
//         break;

//             case "/":
//         res = n1 / n2;
//         break;

// }

// Console.WriteLine("O resultado é " + res);


// DESAFIO 02

Console.WriteLine("Informe a primeira nota: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota: ");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quarta nota: ");
int n4 = int.Parse(Console.ReadLine());

int med = (n1+n2+n3+n4)/4;

switch(med)
{
    case 0:
    Console.WriteLine("REPROVADO MUITO ABAIXO DO ESPERADO");
    break;

        case 1:
    Console.WriteLine("REPROVADO ABAIXO DO ESPERADO");
    break;

        case 2:
    Console.WriteLine("REPROVADO ESTUDE MAIS");
    break;

        case 3:
    Console.WriteLine("REPROVADO FALTOU 1 PONTO");
    break;

        case 4:
    Console.WriteLine("RECUPERAÇÃO PRECISA DE MÉDIA 8");
    break;

        case 5:
    Console.WriteLine("RECUPERAÇÃO PRECISA DE MÉDIA 7");
    break;

        case 6:
    Console.WriteLine("RECUPERAÇÃO PRECISA DE MÉDIDA 8");
    break;

        case 7:
    Console.WriteLine("APROVADO TOME CUIDADO NA PRÓXIMA");
    break;

        case 8:
    Console.WriteLine("APROVADO");
    break;

        case 9:
    Console.WriteLine("APROVADO PARABÉNS");
    break;

        case 10:
    Console.WriteLine("APROVADO COM LOUVOR");
    break;

}


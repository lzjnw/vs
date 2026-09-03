// while estrutura
// while(true)
// {
//     // instruções
// }

// EXERCICIO 01

// int resultado = 0;
// Console.WriteLine("Informe um número: ");
// int numero = int.Parse(Console.ReadLine());

// while(numero != 0)
// {
//     resultado = resultado + numero;

//     Console.WriteLine("Resultado parcial: " + resultado);

//     Console.WriteLine("Informe um número:");
//     numero = int.Parse(Console.ReadLine());

// }

// Console.WriteLine("Resultado final: " + resultado);


// EXERCICIO 02

// int numero = int.Parse(Console.ReadLine());

// while(numero < 100)
// {
//     Console.WriteLine("Insira um valor acima de 100");
// numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Sucesso!");


// DESAFIO 01

// Console.WriteLine("Jogador desafiante insira um valor numérico:");
// int desafiante = int.Parse(Console.ReadLine());

// Console.Clear();

// Console.WriteLine("Jogador desafiado informe um valor: ");
// int desafiado = int.Parse(Console.ReadLine());

// while(desafiante != desafiado)
// {
//     Console.WriteLine("Você errou! Insira um novo valor");
//     desafiado = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Sucesso!");





// EXERCICIO CURSO - LISTA 6 - 11
// Console.WriteLine("Informe a nota do aluno: ");
// int nota = int.Parse(Console.ReadLine());
//  while(nota<0 || nota>10)
// {
//     Console.WriteLine("Nota inválida! Informe a nota entre 0 e 10: ");
//     nota = int.Parse(Console.ReadLine());
// }


// EXERCICIO CURSO - LISTA 6 - 12
// Console.WriteLine("Informe a senha: ");
// int senha = int.Parse(Console.ReadLine());
// while(senha != 1234)
// {
//     Console.WriteLine("Senha incorreta! Informe a senha: ");
//     senha = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Acesso liberado!");



// EXERCICIO CURSO - LISTA 6 - 13

int cont = 0;
int negativo = 0;
while(cont < 10)
{
    Console.WriteLine("Informe um número: ");
    int numero = int.Parse(Console.ReadLine());

    if(numero < 0)
    {
        negativo++;
    }
    cont++;
}
Console.WriteLine("Quantidade de números negativos: " + negativo);


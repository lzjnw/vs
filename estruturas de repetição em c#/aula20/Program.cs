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

Console.WriteLine("Jogador desafiante insira um valor numérico:");
int desafiante = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Jogador desafiado informe um valor: ");
int desafiado = int.Parse(Console.ReadLine());

while(desafiante != desafiado)
{
    Console.WriteLine("Você errou! Insira um novo valor");
    desafiado = int.Parse(Console.ReadLine());
}

Console.WriteLine("Sucesso!");


using fundamentos.models;

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrado");
            exibirMenu = false;
            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
Console.WriteLine("Programa encerrado");





// int soma = 0, numero = 1;

// do 
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;



// } while(numero != 0);

// Console.WriteLine($"A soma dos números digitados: {soma}");


// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; //estrutura pra para no meio da repetição
//     }
// }



// int numero = 2;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }


// Calculadora calc = new Calculadora();

// calc.Somar(2, 5);
// calc.Subtrair(60, 53);
// calc.Multiplicar(7, 4);
// calc.Divisão(120, 60);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);





// Pessoa Pessoa1 = new Pessoa();

// Pessoa1.Nome = "Yarlley";
// Pessoa1.Idade = 17;
// Pessoa1.Apresentar(); 



// Console.WriteLine("Digite uma letra");
// #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
// string letra = Console.ReadLine();
// #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É vogal");
//         break;

//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }







// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possívelCompra = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a compra? {possívelCompra}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Por favor, selecione no mínimo um produto");
// }
// else if (possívelCompra)
// {
//     Console.WriteLine("Compra Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }





// string a = "15-";

// int b = 15;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizado com sucesso!");





// Cast - Casting
// int a = Convert.ToInt32("5");
// int b = int.Parse("10");
// Console.WriteLine(a);
// Console.WriteLine();






//int a = 10;
//int b = 20;

//int c = a + b;

//c += 5;

//Console.WriteLine(c);
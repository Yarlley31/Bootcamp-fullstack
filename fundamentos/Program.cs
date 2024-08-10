using fundamentos.models;

// Pessoa Pessoa1 = new Pessoa();

// Pessoa1.Nome = "Yarlley";
// Pessoa1.Idade = 17;
// Pessoa1.Apresentar(); 

int quantidadeEmEstoque = 3;
int quantidadeCompra = 4;
bool possívelCompra = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a compra? {possívelCompra}");

if (possívelCompra)
{
    Console.WriteLine("Compra Realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}





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
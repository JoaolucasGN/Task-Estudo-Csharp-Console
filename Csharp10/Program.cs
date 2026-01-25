// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
*/
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Lenght; i++)
{
    // booleana true
    if (names[i] == "David")
    {
        // Não é booleana. É comando
        names[i] = "Sammy";
    }
}

foreach (var novonames in names)
{
    Console.WriteLine(novonames);
}
*/

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }

}
/*
// Exemplo de divisão e entrega de resto 

int numero1 = 10;
int numero2 = 3;
int resto = numero1 % numero2; // resto será 1

Console.WriteLine(resto); // Saída: 1
*/



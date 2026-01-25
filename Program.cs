// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*string permission = "Admin|Manager";
int level = 55;
// O método do uso "Permission.Contains();"
Random random = new Random();
int number = random.Next(0,55);
*/

/*
if (level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
    permission.Contains("Admin");
}
 if (level < 55)
{
    Console.WriteLine("Welcome, Admin user.");
    permission.Contains("Admin");
}
 if (level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
    permission.Contains("Admin");
}
 if (level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
    permission.Contains("Admin");
}

Console.WriteLine(number);

*/
string permission = "Admin|Manager";
int level = 55;
// O método do uso "Permission.Contains();"

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
if (permission.Contains("Manager"))
{
    if (level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }

}

    if ((!permission.Contains("Admin")) & (!permission.Contains("Manager")))
    {
        Console.WriteLine("You do not have sufficient privileges!.");
        Console.WriteLine(!permission.Contains("Admin"));
        Console.WriteLine(!permission.Contains("Manager"));
    }
    
Console.WriteLine(level);
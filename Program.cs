// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
switch (fruit)
{
    case "apple":
        Console.WriteLine("$App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine("$$App will display information for banana");
        break;

    case "orange":
        Console.WriteLine("$App will display information for orange");
        break;
}
*/

//três valores codificados: <product #>-<2-letter color code>-<size code>.

// Avaliação de produto
// Método - "sku.Split();" -> É um método que reparte os  arrays em sub arrays, string em substring


string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";
// A sring sku = "01-MN-L", já esta declarada, por isso quando repartida pelo metodo
// em substrings "type", "color", "size", já estão sendo inlcuidas na variavel product. Por isso não
// precisa declaralas no "switch
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat Paints";
        break;
    default:
        type = "Other";
        break;

}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;

}
switch(product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "Other";
        break;
}

Console.WriteLine($"Product:{size}, color:{color}, type:{type}");

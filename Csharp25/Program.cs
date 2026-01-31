// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[,] corporate =
{
    {"Robert","Bavin"}, {"Simon","Bright"},
    {"Kim","Sinclair"}, {"Aashrita","Kamath"},
    {"Sarah","Delucchi"}, {"Sinan","Ali"}

};
string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    string vName = corporate[i, 0];
    string vLastName = corporate[i, 1];

    printEmail(vName, vLastName);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    string vName = external[i, 0];
    string vLastName = external[i, 1];

    printEmail(vName, vLastName, externalDomain);
}

//printEmail("João", "Lucas", "gmail.com");

void printEmail(string name, string lastname, string domain = "contoso.com")
{
    string user = name.Substring(0,2).ToLower() + lastname.ToLower();

    string email = $"{user}@{domain}";

    Console.WriteLine(email);
}
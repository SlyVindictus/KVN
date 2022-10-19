// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string brukerNavn = "kalle";
string passord = "qwerty";

string brukerInput;
string passordInput;

Console.WriteLine("####brukerNavn####");
brukerInput = Console.ReadLine();
Console.WriteLine("####passord####");
passordInput = Console.ReadLine();

if (brukerInput == brukerNavn && passordInput == passord)
{
    //### Inlogget #####
}
else
{
    //### Feil #####
}

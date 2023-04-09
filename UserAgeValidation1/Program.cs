// See https://aka.ms/new-console-template for more information

//rakendus küsib kasut´ajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kubatakse:
//"You are too young to use Instagram
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter yourage");

int userAge = Int32. Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagarm!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}
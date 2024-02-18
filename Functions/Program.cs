// 
Console.WriteLine("coming or going? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

PrintHello();
PrintGoodBye();
static void PrintHello()        // = function / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("CU L8R");
}

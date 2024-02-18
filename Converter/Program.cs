// * fahrenheit = (celsius * 9) / 5 + 32; *celsius = (fahrenheit - 32) * 5 / 9;

using System.Diagnostics;

Console.WriteLine("Convert to [C]elsius or to [F]arenheit?");
char userOp = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine("Enter number for conversion:");
int userNum = Int32.Parse(Console.ReadLine());

    if (userOp == 'C')
{
    toCel(userNum);
}
else if (userOp == 'F')
{
    toFar(userNum);
}
else
{
    Console.WriteLine("invalid input");
}
    
static void toCel(int a)
{
    double result = (a - 32) * 5 / 9;
    Console.WriteLine(result);
}

static void toFar(int a)
{
    double result = (a * 9) / 5 + 32;
    Console.WriteLine(result);
}
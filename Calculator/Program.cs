// 
using System.Numerics;

Console.WriteLine("Enter the operation (+/-/*//):");
char userOp = Char.Parse(Console.ReadLine());
Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secNum = Int32.Parse(Console.ReadLine());

switch (userOp)
{
    case '+':
        Addition(firstNum, secNum);
        break;
    case '-':
        Subtraction(firstNum, secNum);
        break;
    case '*':
        Multiplication(firstNum, secNum);
        break;
    case '/':
        Division(firstNum, secNum);
        break;
    default:
        Console.WriteLine("check yourself.");
        break;
}

static void Addition (int a,  int b)
{
    Console.WriteLine($"{a+b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a - b}");
}

static void Multiplication(int a, int b)
{
    Console.WriteLine($"{a * b}");
}

static void Division(int a, int b)
{
    Console.WriteLine($"{a / b}");
}
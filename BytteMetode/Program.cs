// See https://aka.ms/new-console-template for more information

Console.WriteLine("Indtast to strings at bytte:");
string string1 = Console.ReadLine();
string string2 = Console.ReadLine();
(string1, string2) = Swap(ref string1, ref string2);
Console.WriteLine($"String 1 er nu {string1} og String 2 er nu {string2}");

Console.WriteLine("Indtast to integers at bytte:");
int int1 = int.Parse(Console.ReadLine());
int int2 = int.Parse(Console.ReadLine());
(int1, int2) = Swap(ref int1, ref int2);
Console.WriteLine($"Int 1 er nu {int1} og Int 2 er nu {int2}");

Console.ReadLine();

static (T val1, T val2) Swap<T>(ref T val1, ref T val2)
{
    return (val1, val2) = (val2, val1);
}
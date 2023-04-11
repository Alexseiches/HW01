Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}


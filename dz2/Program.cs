﻿Console.WriteLine("Введи первое число");
string num1 = Console.ReadLine();
int num1int = int.Parse(num1);

Console.WriteLine("Введи второе число");
string num2 = Console.ReadLine();
int num2int = int.Parse(num2);

Console.WriteLine("Введи третье число");
string num3 = Console.ReadLine();
int num3int = int.Parse(num3);

if (num1int > num2int)
{
    if (num1int > num3int)
    {
        Console.WriteLine(num1int + " Самое большое число");

    }
    else
    {
        Console.WriteLine(num3int + " Самое большое число ");
    }

}
else
{
    if (num2int > num3int)
    {
        Console.WriteLine(num2int + " Самое большое число ");

    }
    else
    {
        Console.WriteLine(num3int + " Самое большое число ");
    }
}
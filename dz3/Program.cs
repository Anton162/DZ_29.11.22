Console.WriteLine("Введите число!");
string num = Console.ReadLine();
int numint = int.Parse(num);

if (numint % 2 == 0)
{
    Console.WriteLine(numint + " Четное число");

}
else
{
    Console.WriteLine(numint + " Не четное число");

}
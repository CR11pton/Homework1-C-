// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Write 3 numbers, Writr First: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write Second number: ");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write Third number: ");

int number3 = Convert.ToInt32(Console.ReadLine());
if(number1>number2)
{
    if(number1>number3)
    {
        Console.WriteLine("Max= " + number1);
    }
    else
    {
        Console.WriteLine("Max= " + number3);
    }
}
else
if(number2>number3)
{
    Console.WriteLine("Max= " + number2);
}
else
{
    Console.WriteLine("Max= " + number3);
}
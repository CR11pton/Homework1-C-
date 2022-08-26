// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number1 ");

int number1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter number2 ");

 int number2 = Convert.ToInt32(Console.ReadLine());

  if(number1==number2)
{
    Console.WriteLine("They are equal");
} 
 else 
 if(number1<number2)
{
  Console.WriteLine("Bigger number "  +  number2);
  Console.WriteLine("Smalller number "  +  number1);
}
  else
{
  Console.WriteLine("Bigger number " + number1);
  Console.WriteLine("Smaller number " + number2); 
}


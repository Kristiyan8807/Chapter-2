//Декларирайте две променливи от тип int. Задайте им стойности
//съответно 5 и 10. Разменете стойностите им и ги отпечатайте.
using System;

class Program
{
    static void Main()
    {
        int number1 = 5;
        int number2 = 10;
        Console.WriteLine(number1);
        Console.WriteLine(number2);

        int swap = number2;
        number2 = number1;
        number1 = swap;
        Console.WriteLine(number1);
        Console.WriteLine(number2);

    }
}

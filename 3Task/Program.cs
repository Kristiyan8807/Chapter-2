using System;

namespace _3Task
{
    class Program
    {
        static void Main()
        {
            float number1 = 1.234567f;
            float number2 = 1.234568f;
            Console.WriteLine(number1 == number2); //false
            number1 = 1.234567f;
            number2 = 1.234567f;
            Console.WriteLine(number1 == number2); // true
            number1 = 1.23456779789798f;
            number2 = 1.23456777908080f;
            Console.WriteLine(number1 == number2); // true - precision error
        }
    }
}

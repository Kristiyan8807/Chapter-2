//Декларирайте променлива от тип char и присвоете като стойност
//символа, който има Unicode код 72 (използвайте калкулатора на
//Windows, за да намерите шестнайсетичното представяне на 72).
using System;

class Program
{
    static void Main()
    {
        char mychar = '\u0048';
        Console.WriteLine(mychar);
    }
}


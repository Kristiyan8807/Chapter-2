﻿//Декларирайте две променливи от тип string със стойности "Hello" и
//"World". Декларирайте променлива от тип object. Присвоете на тази
//променлива стойността, която се получава от конкатенацията на двете
//стрингови променливи(добавете интервал, ако е необходимо). Отпе-
//чатайте променливата от тип object.
using System;

class Program
{
    static void Main()
    {
        string mystring1 = "Helloo";
        string mystring2 = "World";
        object result = mystring1 + " " + mystring2;
        Console.WriteLine(result);
    }
}

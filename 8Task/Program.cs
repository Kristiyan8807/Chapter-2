//Декларирайте две променливи от тип string и им присвоете стойности
//"Hello" и "World". Декларирайте променлива от тип object и ѝ присвоете
//стойността на конкатенацията на двете променливи от тип string (не
//изпускайте интервала по средата). Декларирайте трета променлива от
//тип string и я инициализирайте със стойността на променливата от тип
//object.
using System;

class Program
{
    static void Main()
    {
        string myString1 = "Hello";
        string myString2 = "World";
        object myObject = myString1 + ' ' + myString2;
        string myString = (string)myObject;
        Console.WriteLine(myString);

    }
}


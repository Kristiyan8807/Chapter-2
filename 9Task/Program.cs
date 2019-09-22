//Декларирайте две променливи от тип string и им присвоете стойност
//"The "use" of quotations causes difficulties." (без първите и
//последни кавички). В едната променлива използвайте quoted string, а
//в другата не го използвайте.
using System;
class Program
{
    static void Main()
    {
        string myString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(myString);
    }
}


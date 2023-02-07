using System;
using BasicSolution;

namespace ClassCSharp;

class Program
{
    static void Main(string[] args)
    {
        ClassOne classOne = new();
        var result = classOne.Add2();
        Console.WriteLine(result);
    }
}


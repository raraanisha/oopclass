
//using ABC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Generics
{
    //generics takes type as an parameter.
    public void PrintDetails<T>(T x, T y)
    {
        Console.WriteLine($"Value of x: {x} and value of y is {y}.");
    }
}

public class Generics<T, U>
{
    //generics takes type as an parameter.
    public void PrintDetails(T x, U y)
    {
        Console.WriteLine($"Value of x: {x} and value of y is {y}.");
    }
}
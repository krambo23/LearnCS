#define DEBUG

using System;
using System.Diagnostics;

public class MyClass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        System.Console.WriteLine(msg);
    }

    // If Second Parameter is 'true', Will Throw Error
    // If Second Parameter is 'false', Will Display Warning
    [Obsolete("Don't Use OldMethod - Use NewMethod Instead", true)]
    public static void OldMethod()
    {
        System.Console.WriteLine("Old Method");
    }

    public static void NewMethod()
    {
        System.Console.WriteLine("New Method");
    }
}

class Test
{
    static void function1()
    {
        MyClass.Message("FN1");
        function2();
    }

    static void function2()
    {
        MyClass.Message("FN2");
    }

    public static void Main(string[] args)
    {
        MyClass.Message("Main FN");
        function1();

        MyClass.OldMethod();
    }
}
// pg 236
// pg 237, 238
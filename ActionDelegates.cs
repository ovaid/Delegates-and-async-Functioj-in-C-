/* 
Action Delegates : Action Delegates is similar to the
Func Delegates except that the Action Delegates doesnot return a value. 
In otherwords, an Action Delegate can be used with a method that
has a void return type.
examples are given below :-


*/
using System;

public delegate void Print(string val);

namespace Rameez
{
    class Program
    {
        static void ConsolePrint(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt("0418");

            // Using Action keyword
            Action<string> printActionDel = ConsolePrint;
            printActionDel("0418");

            // Using Action with new keyword
            Action<string> printActionDel2 = new Action<string>(ConsolePrint);
            printActionDel2("0418");

            // Using lambda function/anonymous function
            Action<string> printActionDel3 = (s) => Console.WriteLine(s);
            printActionDel3("0418");
        }
    }
}


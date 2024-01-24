/* 
Action Delegates : Action Delegates is similar to the
Func Delegates except that the Action Delegates doesnot return a value. 
In otherwords, an Action Delegate can be used with a method that
has a void return type.
examples are given below :-


*/
using System;

public delegate void Print(int val);

namespace Rameez
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(0418);

            // Using Action keyword
            Action<int> printActionDel = ConsolePrint;
            printActionDel(0418);

            // Using Action with new keyword
            Action<int> printActionDel2 = new Action<int>(ConsolePrint);
            printActionDel2(0418);

            // Using lambda function/anonymous function
            Action<int> printActionDel3 = (i) => Console.WriteLine(i);
            printActionDel3(0418);
        }
    }
}


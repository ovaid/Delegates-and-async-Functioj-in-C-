

using System;
using System.Threading.Tasks;

//Delegates :-  when a mwethod is passing as a parameter to a menthod is called a Delegate ,
// Syntax :-  [access modifier] delegate [return type] delegateName (paramter name);
//Delegate is used to declare events and asynchronous methods in C#.
public delegate void MyDelegate(string msg);

namespace YourNamespace
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //example of delegate:- 
            MyDelegate del = ClassA.MethodA;
            del("hello world");

            del = ClassB.MethodB;
            del("hello world");

            del = (string msg) => Console.WriteLine("This is called Lambda expression : " + msg);
            del("hello world");
             //example of async functions:-
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess2();

            await Task.WhenAll(result1, result2);

            Console.WriteLine("After two long processes.");

            int val1 = await result1;
            DisplayResult(val1);

            int val2 = await result2;
            DisplayResult(val2);
        }

        static async Task<int> LongProcess1()
        {
            Console.WriteLine("Long Process1 Started");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Long Process 1 Executing");
            }

            await Task.Delay(3000);

            Console.WriteLine("Long Process1 Ended");

            return 10;
        }

        static async Task<int> LongProcess2()
        {
            Console.WriteLine("Long Process2 Started");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Long Process 2 Executing");
            }

            await Task.Delay(3000);

            Console.WriteLine("Long Process2 Ended");

            return 20;
        }

        static void DisplayResult(int val)
        {
            Console.WriteLine("Result: " + val);
        }
    }
}

class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("This is ClassA.MethodA() with parameter : " + message);
    }
}

class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("This is ClassB.MethodB() with parameter : " + message);
    }
}

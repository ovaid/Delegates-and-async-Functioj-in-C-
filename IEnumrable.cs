using System;
using System.Collections.Generic;


class LazyEagerExecution
{
    public static void Main()
    {

        foreach (int i in SimpleIterator())
        {
            Console.WriteLine(i);
            //UNTILL WE DID NOT USE THE FUNCTION IT WILL NOT RETURM THE VALUES THAT IS ====LAZY ECRCUTION==== 
            //this will print he first return value from the IEnumerable SimpleIterator because it will
            //print the first return value from the method and will come out of the loop, and the SimpleIterator 
            //not be invoked untill it is called again neither it will iterate on the value in the function.
            break;
        }

        Console.WriteLine("--------------------------------");

        foreach (int i in GetList())
        {
            //this will print all the values , which GetList() method is returning;
            Console.WriteLine(i);
            //break;
        }

    }

    // Lazy Execution
    public static IEnumerable<int> SimpleIterator()
    {
        yield return 100;

        for (int i = 0; i < 5; i++) yield return i;

        yield return 500;
        yield return 600;
        Console.WriteLine("Bye!");
    }


    // Eager Execution
    public static IEnumerable<int> GetList()
    {
        List<int> list = new List<int>();

        list.Add(100);

        for (int i = 0; i < 5; i++) list.Add(i);

        list.Add(500);
        list.Add(600);
       //After Adding the items in the list
        //list = [100, 0, 1, 2, 3, 4, 500, 600];

        Console.WriteLine($"Bye! {String.Join(',', list)}");
        return list;
    }
}
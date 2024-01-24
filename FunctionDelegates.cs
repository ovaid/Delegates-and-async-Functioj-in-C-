/* 
Function Delegate Methods👎
C# includes built_in generic delegate types Func and Actions , so that we don't mneed to 
define cutome delegates in most cases.

Func is a generic delegate included in the system namespace. It has zero or more input 
params and one output param. The last param is called the output parameter or we can say
the return type.
examples is given below:-


 public delegate TResult Func<in T, out TResult>(T arg); 

the [in T or T arg] ==> is an input param;

 TResult in the <> braces is the output or return val.

similarly we can have Func with multiple inputs and one output or return type.

example:- 


 public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);

A Func delgate can be assigned 0 - 16 input parametes and one output parameter. if we dont 
pass any input parameter ot the Func delegate but their shlud be one output parameter.
example:-   
  Func<int> getRandomNumber; ===> this is a Func delegate with z0 in parameter, but only
  having one output parameter.


  we can also assign anonymous method to the fucntion delegate by using thee delegate keywprd.
  example:- 

  Func<int> getRandomNumber = delegate()
                              {
                                Random rnd = new Random();
                                return rnd.Next(1, 200)
                              };


   ========================OR=========================

   we can write this using lambda function 

   Func<int> getRandomNumber = () => new Random().Next(1, 200);                           
*/

namespace System
{
  class program
   {
     static int Sum(int x, int y)
     {
         return x + y;
     }

     static void Main(string[] args)
     {
        Func<int, int, int> add = Sum;
        int result = add(10,20);
        Console.WriteLine(result);

        Func<int> getRandomNumber = delegate()
                            {
                            Random rnd = new Random();
                            return rnd.Next(1, 200);
                            };
        Console.WriteLine(getRandomNumber());
     }
   }
}


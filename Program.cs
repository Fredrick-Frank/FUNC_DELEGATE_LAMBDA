using System;

namespace Func_Delegate
{
    //using the lambda expression
    public class Program
    {
        public static void Main()
        {
            Func<int> getRandomNumber = () => new Random().Next(1,100);

            Func<int, int, int> Sum = (x,y) => x + y;

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(Sum(100,50));
        }
    }
}
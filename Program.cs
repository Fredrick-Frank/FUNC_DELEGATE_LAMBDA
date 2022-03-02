using System;

namespace Func_Delegate
{
    //using the lambda expression
    public class Program
    {
        public static void Main()
        {
            Func<int> getRandomNumber = () => new Random().Next(1,100); //getting random numbers

            Func<int, int, int> Sum = (x,y) => x + y; //utilizing the FUNC delegate to print out the output

            Console.WriteLine(getRandomNumber()); //print out the random number
            Console.WriteLine(Sum(100,50)); //addition of the variable x & y
        }
    }
}

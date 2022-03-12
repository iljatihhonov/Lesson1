using System;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hi, {userName}!");
        }
    }
}
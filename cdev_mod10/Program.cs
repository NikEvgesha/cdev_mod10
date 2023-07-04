using System;
using System.Runtime.CompilerServices;

namespace cdev_mod10
{
    class Program 
    {
        
        static ILogger Logger { get; set; }
        static void Main(string[] args) 
        {
            Logger = new Logger();
            var calc = new Calculator(Logger);
            calc.Work();
            Console.ReadKey();      
        }
    }

    public interface ISum
    {
        decimal Sum(decimal num1, decimal num2);
    }

    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }

    public interface IWorker
    {
        void Work();
    }
}


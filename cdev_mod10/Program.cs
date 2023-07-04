using System; 

namespace Cdev_Interfaces
{
    class Program 
    {
      
        static void Main(string[] args) 
        {
            Calculator calc = new Calculator();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое слагаемое: ");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Введите второе слагаемое");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"Сумма: {calc.Sum(num1, num2)}");

                }
                catch (IOException ex) { Console.WriteLine(ex); }
                catch (OutOfMemoryException ex) { Console.WriteLine(ex); }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex); }
                catch (FormatException ex) { Console.WriteLine(ex); }
                catch (OverflowException ex) { Console.WriteLine(ex); }
                finally
                {
                    Console.WriteLine("Для продолжения нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
                
        }
    }

    public interface ISum
    {
        decimal Sum(decimal num1, decimal num2);
    }

    public class Calculator : ISum
    {
        public decimal Sum(decimal num1, decimal num2) => num1 + num2;
    }
}


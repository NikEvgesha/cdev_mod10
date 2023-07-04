using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdev_mod10
{
    public class Calculator : IWorker
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public decimal Sum(decimal num1, decimal num2) => num1 + num2;

        public void Work()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое слагаемое: ");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Введите второе слагаемое");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"Сумма: {this.Sum(num1, num2)}");

                }
                catch (IOException ex) { Logger.Error(ex.Message); }
                catch (OutOfMemoryException ex) { Logger.Error(ex.Message); }
                catch (ArgumentOutOfRangeException ex) { Logger.Error(ex.Message); }
                catch (FormatException ex) { Logger.Error(ex.Message); }
                catch (OverflowException ex) { Logger.Error(ex.Message); }
                finally
                {
                    Logger.Event("Вычисление выполнено. Для продолжения нажмите Enter");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }

    
}

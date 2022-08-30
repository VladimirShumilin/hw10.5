using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    internal class MiniCalc: Calculator.Calculator
    {
        private readonly Logger logger;

        public MiniCalc(Logger logger)
        {
            this.logger = logger;
        }

        public void Work()
        {
            while (true)
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите первый параметр для сложения");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Введите второй параметр для сложения");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

                    logger?.Event($"Сложение двух чисел {num1} и {num2} cумма: {Add(num1, num2)}");

                    Console.WriteLine($"Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                }
                //Console.WriteLine
                catch (IOException) { /*тут запись ошибки другим методом. например в файл*/  }
                catch (ArgumentNullException) { /*тут запись ошибки другим методом. например в файл*/  }
                //Console.ReadLine
                catch (OutOfMemoryException ex) { logger?.Error(ex.ToString()); }
                catch (ArgumentOutOfRangeException ex) { logger?.Error(ex.ToString()); }
                //Convert.ToDecimal
                catch (FormatException ex) { logger?.Error(ex.ToString()); }
                catch (OverflowException ex) { logger?.Error(ex.ToString()); }
        }
    }
}

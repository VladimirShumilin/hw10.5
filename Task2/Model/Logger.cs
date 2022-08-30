using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    internal class Logger : ILogger
    {
        public void Error(string message)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Для продолжения нажмите любую клавишу");
                Console.ReadKey();
               
            }
            //Console.WriteLine
            catch (IOException) { /*тут запись ошибки другим методом. например в файл*/  }
            catch (FormatException) { /*тут запись ошибки другим методом. например в файл*/  }
            catch (ArgumentNullException) { /*тут запись ошибки другим методом. например в файл*/  }
            finally { Console.ForegroundColor = prevColor; }
        }

        public void Event(string message)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
                
            }
            //Console.WriteLine
            catch (IOException) { /*тут запись ошибки другим методом. например в файл*/  }
            catch (FormatException) { /*тут запись ошибки другим методом. например в файл*/  }
            catch (ArgumentNullException) { /*тут запись ошибки другим методом. например в файл*/  }
            finally { Console.ForegroundColor = prevColor; }
        }
    }
}

using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Класс базовых функций калькулятора
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public  decimal Add(decimal a, decimal b)=>  a + b;
       


    }
}

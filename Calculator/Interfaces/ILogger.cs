using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс для логирования ошибок и событий
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Вывод  сообщения об ошибке
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
        /// <summary>
        /// Вывод простого уведомления
        /// </summary>
        /// <param name="message"></param>
        void Event(string message);
    }
}

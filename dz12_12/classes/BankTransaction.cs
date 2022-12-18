using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik13.classes
{
    internal class BankTransaction
    {
        int sum;
        DateTime date;

        /// <summary>
        /// Свойство для чтения: суммы операции
        /// </summary>
        internal int Sum { get { return sum; } }

        /// <summary>
        /// Свойство для чтения: даты операции
        /// </summary>
        internal DateTime Date { get { return date; } }


        /// <summary>
        /// Фиксирование новой операции на счету; записывается сумма и время операции
        /// </summary>
        /// <param name="sum"></param>
        internal BankTransaction(int sum)
        {
            this.sum = sum;
            date = DateTime.Now;
        }
    }
}
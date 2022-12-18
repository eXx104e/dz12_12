using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik14
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]
    internal class DeveloperInfoAttribute : Attribute
    {
        /// <summary>
        /// Разработчик
        /// </summary>
        public string Developer;
        /// <summary>
        /// Дата разработки
        /// </summary>
        public string Date { get; set; }
        public DeveloperInfoAttribute(string developer)
        {
            Developer = developer;
        }
    }
}


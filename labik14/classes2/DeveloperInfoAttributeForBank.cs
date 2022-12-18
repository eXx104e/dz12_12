using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik14
{
    internal class DeveloperInfoAttributeForBank : Attribute
    {
        /// <summary>
        /// Разработчик
        /// </summary>
        public string Developer;
        /// <summary>
        /// Организация
        /// </summary>
        public string Organization { get; set; }
        public DeveloperInfoAttributeForBank(string developer)
        {
            Developer = developer;
        }
    }
}

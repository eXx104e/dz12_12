using labik13.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik13.classes
{
    internal class Buildings
    {
        /// <summary>
        /// Массив на 10 зданий
        /// </summary>
        internal Building[] list_building = new Building[]
        {
            new Building(), new Building(), new Building(), new Building(), new Building(),
            new Building(), new Building(), new Building(), new Building(), new Building()
        };

        internal Building this[int index]
        {
            get
            {
                if (index >= 1 && index <= 10)
                {
                    return list_building[index - 1];
                }
                else
                {
                    while (index < 1 || index > 10)
                    {
                        Console.WriteLine("Здания с таким индексом нет. Введите другой индекс от 1 до 10 ");
                        index = int.Parse(Console.ReadLine());
                    }
                    return list_building[index - 1];
                }
            }
            set
            {
                if (index >= 1 && index <= 10)
                {
                    list_building[index - 1] = value;
                }
                else
                {
                    while (index < 1 || index > 10)
                    {
                        Console.WriteLine("Здания с таким индексом нет. Введите другой индекс от 1 до 10 ");
                        index = int.Parse(Console.ReadLine());
                    }
                    list_building[index - 1] = value;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik13.classes
{
    internal class Building
    {
        static Random rnd = new Random();

        int number_building { get; set; } // здания
        int height { get; set; }  // высота
        int number_floors { get; set; } // этажи
        int number_apartments { get; set; } // квартиры
        int number_porch { get; set; }  // подъезды
        static List<int> list_number_building = new List<int>(100);

        /// <summary>
        /// Свойство "номер здания", если присваеваемый номер здания был использован раньше, то генерируется уникальный номер
        /// </summary>
        internal int Number_building
        {
            get { return number_building; }
            set
            {
                if (list_number_building.Contains(value))
                {
                    int temp = rnd.Next();
                    while (list_number_building.Contains(temp))
                    {
                        temp = rnd.Next();
                    }
                    list_number_building.Add(temp);

                    number_building = temp;
                }
                else
                {
                    list_number_building.Add(value);
                    number_building = value;
                }
            }
        }
        /// <summary>
        /// Свойство "высота здания"
        /// </summary>
        internal int Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// Свойство "количество этажей"
        /// </summary>
        internal int Number_floors
        {
            get { return number_floors; }
            set { number_floors = value; }
        }
        /// <summary>
        /// Свойство "количество квартир"
        /// </summary>
        internal int Number_apartments
        {
            get { return number_apartments; }
            set { number_apartments = value; }
        }
        /// <summary>
        /// Свойство "количество подъездов"
        /// </summary>
        internal int Number_porch
        {
            get { return number_porch; }
            set { number_porch = value; }
        }


        /// <summary>
        /// Подсчет высоты одного этажа переданного дома
        /// </summary>
        /// <param name="height"></param>
        /// <param name="number_floors"></param>
        /// <returns></returns>
        internal double FloorHeight(Building building)
        {
            return (double)building.height / building.number_floors;
        }

        /// <summary>
        /// Подсчет количества квартир в одном подъезде здания
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        internal int NumberApartmentsInEntrance(Building building)
        {
            return building.number_apartments / building.number_porch;
        }

        /// <summary>
        /// Подсчет количества квартир на одном этаже
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        internal int NumberApartmentsInFloors(Building building)
        {
            int temp = building.number_apartments / building.number_porch;    // количество квартир в одном подъезде

            return temp / building.number_floors;
        }

        /// <summary>
        /// Печать информации о доме
        /// </summary>
        internal void PrintInfoBuilding()
        {
            Console.WriteLine($"Номер здания: {number_building} \n" +
                $"Высота: {height} \n" +
                $"Количество этажей: {number_floors} \n" +
                $"Количество квартир: {number_apartments} \n" +
                $"Количество подъездов: {number_porch}");
        }
    }
}

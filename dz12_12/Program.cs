using labik13.classes;

namespace labik13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания 1 и 2. Банковский счет\n");

            BankAccount bank_acc = new BankAccount("Гизатуллин Сергей", 14000, "Расчетный");
            Console.WriteLine($"Держатель счета: {bank_acc.Account_holder} \n");

            bank_acc.ChangeBalanceAccount(-100);
            bank_acc.ChangeBalanceAccount(1300);
            bank_acc.ChangeBalanceAccount(120);


            bank_acc.Account_holder = "Спанчбобский Максим";
            Console.WriteLine($"Держатель счета: {bank_acc.Account_holder}");
            Console.WriteLine($"Номер счета: {bank_acc.Account_number}");
            Console.WriteLine($"Тип счета: {bank_acc.Account_type} \n");

            Console.WriteLine($"Первая операция: \n" +
                $"сумма {bank_acc[0].Sum}, дата: {bank_acc[0].Date.ToLongDateString()}, " +
                $"время: {bank_acc[0].Date.ToShortTimeString()}");

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Задание 3. Свойства \n");

            Building building = new Building();
            building.PrintInfoBuilding();

            building.Number_building = 1;
            building.Height = 100;
            building.Number_floors = 15;
            building.Number_apartments = 10000;
            building.Number_porch = 5;

            Console.WriteLine();
            building.PrintInfoBuilding();

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Задание 4. Индексатор");

            Random rnd = new Random();
            Buildings buildings = new Buildings();

            for (int i = 0; i < 10; i++)
            {
                Building temp = buildings.list_building[i];

                temp.Number_building = rnd.Next();
                temp.Height = rnd.Next(30, 150);
                temp.Number_floors = rnd.Next(5, 35);
                temp.Number_apartments = rnd.Next(100, 1000);
                temp.Number_porch = rnd.Next(1, 20);
            }

            Console.WriteLine("Введите номер желаемого здания: ");
            int number_building = int.Parse(Console.ReadLine());

            Building building1 = buildings[number_building];

            building1.PrintInfoBuilding();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
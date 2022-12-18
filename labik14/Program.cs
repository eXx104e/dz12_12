using labik14.classes2;
using System.Diagnostics;

namespace labik14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Условный атрибут");

            BankAccount bank_acc = new BankAccount("Гизатуллин Сергей", 14000, "Расчетный");
            bank_acc.DumpToScreen();

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Задание 2. Пользовательский атрибут");

            System.Reflection.MemberInfo information;
            information = typeof(RationalNumbers);

            object[] attribute = information.GetCustomAttributes(false);

            foreach (Attribute atr in attribute)
            {
                if (atr is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute dia = (DeveloperInfoAttribute)atr;
                    Console.WriteLine($"Разработчик: {dia.Developer}, дата разработки: {dia.Date}");
                }
            }

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Задание 3. Пользовательский атрибут");

            System.Reflection.MemberInfo info;
            info = typeof(BankAccount);

            object[] attr = info.GetCustomAttributes(false);
            foreach (Attribute atr in attr)
            {
                if (atr is DeveloperInfoAttributeForBank)
                {
                    DeveloperInfoAttributeForBank dia_for_bank = (DeveloperInfoAttributeForBank)atr;
                    Console.WriteLine($"Разработчик: {dia_for_bank.Developer}, Организация: {dia_for_bank.Organization}");
                }
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
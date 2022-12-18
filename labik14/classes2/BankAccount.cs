using labik14.classes2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik14
{
    [DeveloperInfoAttributeForBank("Bogomolov Nikita", Organization = "IT company")]
    internal class BankAccount
    {
        Random rnd = new Random();

        int? account_number;
        int balance;
        string account_type;
        string account_holder;
        static int count_files;
        List<BankTransaction> list_transactions;

        /// <summary>
        /// Свойство чтения: номера банковского счета
        /// </summary>
        internal int? Account_number { get { return account_number; } }

        /// <summary>
        /// Свойство чтения: типа банковского счета
        /// </summary>
        internal string Account_type { get { return account_type; } }

        /// <summary>
        /// Свойство чтения и записи: держателя банковского счета
        /// </summary>
        internal string Account_holder
        {
            get { return account_holder; }
            set { account_holder = value; }
        }

        internal BankTransaction this[int index]
        {
            get
            {
                if (index > list_transactions.Count)
                {
                    Console.WriteLine("Записи с данным номером не существует");
                    return null;
                }
                else
                {
                    return list_transactions[index];
                }
            }
            set
            {
                if (index >= list_transactions.Count)
                {
                    Console.WriteLine("dwdwdw");  // Доделать что-то не работает (нужно задать список)
                }
                else
                {
                    list_transactions[index] = value;
                }
            }
        }

        /// <summary>
        /// Держатель банковского счета, баланс счета и его тип
        /// </summary>
        /// <param name="account_holder"></param>
        /// <param name="balance"></param>
        /// <param name="acc_type"></param>
        internal BankAccount(string account_holder, int balance, string account_type)
        {
            this.account_holder = account_holder;
            this.balance = balance;
            this.account_type = account_type;
            this.account_number = rnd.Next();
            this.list_transactions = new List<BankTransaction>();
        }

        /// <summary>
        /// Метод записывает все транзакции переданного аккаунта в файл
        /// </summary>
        /// <param name="song"></param>
        internal void Dispose(BankAccount bank_account)
        {
            string new_file = "file" + $"{count_files}";
            StreamWriter file = new StreamWriter(new_file);
            foreach (BankTransaction transaction in bank_account.list_transactions)
            {
                file.WriteLine(transaction.Sum);
            }
            GC.SuppressFinalize(file);
        }

        /// <summary>
        /// Изменение баланса, переданного счета; если переданная сумма отрицательна, то со счета снимают деньги, 
        /// если положительна, то кладут
        /// </summary>
        /// <param name="bank_account"></param>
        /// <param name="sum"></param>
        internal void ChangeBalanceAccount(int sum)
        {
            balance += sum;
            list_transactions.Add(new BankTransaction(Math.Abs(sum)));
        }

        /// <summary>
        /// Печать информации о счете: держатель, номер, баланс и тип счета
        /// </summary>
        [Conditional("DEBUG_ACCOUNT")]
        internal void DumpToScreen()
        {
            Console.WriteLine($"Держатель счета - {this.account_holder}, Номер счета - {this.account_number} \n " +
                $"баланс - {this.balance} рублей, тип счета - {this.account_type} \n\n Все операции по счету:");

            foreach (BankTransaction transaction in list_transactions)
            {
                Console.WriteLine($"Сумма: {transaction.Sum}р,  дата: {transaction.Date.ToShortDateString()},  " +
                    $"время: {transaction.Date.ToLongTimeString()}");
            }
        }
    }
}
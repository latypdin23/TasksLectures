using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        enum Banks
        {
            текущий,
            сберегательный
        }
        enum VUZ
        {
            КФУ,
            КАИ,
            КХТИ
        }
        struct Employer
        {
            public string name;
            public VUZ vuz;

            public void Print()
            {
                Console.WriteLine($"Работник по имени {name} рабоатет в вузе {vuz}");
            }

        }
        struct BankAccount
        {
            public int id;
            public Banks type;
            public decimal balance;

            //метод, который ничего не возвращает и ничег не принимает
            public void Print()
            {
                Console.WriteLine($"Номер счета={id}, тип - {type}, баланс: {balance}");
            }
        }
        static void Main(string[] args)
        {

            Banks myBanks = Banks.сберегательный;
            Console.WriteLine(myBanks+" "+(int)myBanks);


            BankAccount bankAccount = new BankAccount();
            bankAccount.id = 1;
            bankAccount.type = Banks.текущий;
            bankAccount.balance = 90m;

            bankAccount.Print();


            BankAccount bankAccount1 = new BankAccount() 
            { 
                id = 2, 
                type = Banks.сберегательный, 
                balance = 80M 
            };
            bankAccount1.Print();


            Employer employer = new Employer()
            {
                name = "Ivan",
                vuz = VUZ.КФУ
            };
            employer.Print();

            Console.ReadKey();
        }
    }
}

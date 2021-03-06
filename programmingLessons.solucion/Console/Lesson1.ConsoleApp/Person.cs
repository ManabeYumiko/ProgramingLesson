using System;

namespace Lesson1.ConsoleApp
{
    public class Account
    {
        public Account(Person person)
        {
            Owner = person;
        }

        public decimal Balance { get; protected set; }

        public Person Owner { get; set; }

        public decimal Cashres(decimal cashres)
        {
            int result = 0;
            if (Owner.Age > 25)
            {
                return Balance -= cashres;
            }
            else
            {
                Console.WriteLine("is unable to withdraw, invalid age to do it!");
            }
            return result;
        }

        public decimal CashSum(decimal cashsum)
        {
            int result = 0;
            if (cashsum > 0)
            {
                return Balance += cashsum;
            }
            else
            {
                Console.WriteLine("incorrect money value, please set a correct amount!");
            }
            return result;
        }

        public virtual string ShowAccountData()
        {
            string kk = "";
            string Message = $"The account belongs to {Owner.Dni} {Owner.Name} {Owner.Age} that have a balance of {Balance} ";
            Console.WriteLine(Message);
            return kk;
        }
    }

    // there is the base class person
    public class Person
    {
        public Person()
        {
        }

        public int Age { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }

        public bool IsLegalperson()
        {
            bool result = Age > 18;
            return result;
        }

        public void Show()
        {
            string message = $"The user data of {Name} are age: {Age} and DNI: {Dni}";
            Console.WriteLine(message);
        }
    }

    //Here we have the young account class
    public class YoungAccount : Account
    {
        public decimal Bonus { get; set; }

        public override string ShowAccountData()
        {
            Console.WriteLine($" You have a bonification of {Bonus}, to have a total of {Balance + Bonus}");
            return "";
        }
    }
}
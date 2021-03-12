using System;

namespace Lesson1.ConsoleApp
{
    public class Account : Person
    {
        public Account()
        {
        }

        public decimal Balance { get; protected set; }

        public decimal Cashres(decimal cashres)
        {
            return Balance -= cashres;
        }

        public decimal CashSum(decimal cashsum)
        {
            return Balance += cashsum;
        }

        public string ShowAccountData()
        {
            string data = $"The account  belongs to {Name} {Age} {Dni} that have a balance of {Balance} ";
            return data;
        }
    }

    public class Person
    {
        public Person()
        {
        }

        public int Age { get; set; }
        public int Dni { get; private set; }
        public string Name { get; set; }

        public bool OldMan()
        {
            bool Result = Age > 18;
            return Result;
        }

        public void Show()
        {
            string message = $"The user data of {Name} are age: {Age} and DNI: {Dni}";
            Console.WriteLine(message);
        }
    }

    public class YoungAccount : Account
    {
        public YoungAccount()
        {
        }

        public decimal Bonification { get; set; }

        public decimal Bonus()
        {
            decimal porcentaje = (Balance * 23) / 100;
            return Bonification += porcentaje;
        }

        public string ShowYoungAccountData()
        {
            string Mensaje = $"{Balance} and because your age you receive a bonification of {Bonification} then you have a total balance of {Balance + Bonification}";
            return Mensaje;
        }

        private bool Oldman(bool v)
        {
            bool result = Age >= 25;
            return result;
        }
    }
}
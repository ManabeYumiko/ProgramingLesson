namespace Lesson1.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Alejandro";
            person.Age = 19;
            person.Dni = 1000286721;
            person.Show();

            Account account = new Account(person);

            account.ShowAccountData();
        }
    }
}
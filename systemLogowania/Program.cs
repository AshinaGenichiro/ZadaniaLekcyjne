using System.Reflection.Metadata;

namespace systemLogowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string haslo = "pass123";
            int attemptCount = 0;
            Console.Write("Zaloguj się: \n");
            while (attemptCount < 3)
            {
                attemptCount++;
                Console.WriteLine("Wpisz login: ");
                string sprawdzlogin = Console.ReadLine();
                Console.WriteLine("Wpisz haslo: ");
                string sprawdzHaslo = Console.ReadLine();
                if (login.Equals(sprawdzlogin) && haslo.Equals(sprawdzHaslo))
                {
                    Console.WriteLine($"Zalogowales sie za {attemptCount} próbą");
                    break;
                } 
                if(attemptCount > 0)
                {
                    Console.WriteLine($"Złe haslo lub login zostało ci {3-attemptCount} prób");
                }

            }
        }
    }
}
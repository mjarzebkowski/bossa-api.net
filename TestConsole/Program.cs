using System;
using pjank.BossaAPI;

namespace TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var client = new NolClient(false, false);

            client.Login();
            client.SecurityListStart();

            Console.ReadKey();
            client.Logout();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User's ID: ");
            string user = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(user = Encode64(user));

            Console.ReadKey();
        }
        public static string Encode64(string userID)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(userID);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}

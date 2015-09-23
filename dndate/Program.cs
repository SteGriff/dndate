using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndate
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = "";

            if (args.Length > 0)
            {
                dateFormat = args.Aggregate((a, b) => a + " " + b);
            }
            else
            {
                Console.Write("Enter date format: ");
                dateFormat = Console.ReadLine();
            }

            try
            {
                Console.WriteLine(DateTime.UtcNow.ToString(dateFormat));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad date format");
            }
        }
    }
}

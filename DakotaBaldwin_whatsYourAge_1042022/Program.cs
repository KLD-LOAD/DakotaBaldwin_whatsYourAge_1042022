using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Added System.Threading to allow timing of Console Output
using System.Threading;

namespace DakotaBaldwin_whatsYourAge_1042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Grab user's age and store in variable supposedAge as string
            Console.WriteLine("Please enter your age.");
            string supposedAge = Console.ReadLine();

            // Convert the string to a 32 bit integer and store in variable intSupAge
            int intSupAge = Int32.Parse(supposedAge);

            // if user is 17 or older output they can watch R rated movies.
            if (intSupAge >= 17);
            {
                Console.WriteLine("\nWatch rated R movies unsupervised\n");
                var milliseconds = 2500;
                Thread.Sleep(milliseconds);
            }
            
            // If user is 16 or older output they can drive a car unsupervised
            if (intSupAge >= 16);
            {
                Console.WriteLine("Can drive a car unsupervised\n");
                var milliseconds = 2500;
                Thread.Sleep(milliseconds);
            }
            
            // IF user is 21 or older output they meet the minimum legal drinking age
            if (intSupAge >= 21);
            {
                Console.WriteLine("Miminimum legal drinking age\n");
                var milliseconds = 2500;
                Thread.Sleep(milliseconds);
            }

            // Wait for user input before closing
            Console.WriteLine("Please click any button to Continue...");
            Console.ReadKey();
        }
    }
}

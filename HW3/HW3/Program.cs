using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();

            while (true)
            {
                for (int j = 1; j <= 3; j++)
                {   
                    // Loop to deposit 3 quarters
                    Console.WriteLine(vm.DepositQuarter());
                }

                // Shows inventory and prices
                Console.WriteLine('\n' + "0: Twix = $0.75");
                Console.WriteLine('\n' + "1: Snickers = $1.00");
                Console.WriteLine('\n' + "2: KitKat = $1.25");
                Console.WriteLine('\n' + "3: Crunch = $1.50" + '\n');

                // Promts user to make a selection
                Console.WriteLine("Enter 0 - 3 to select candybar:" + '\n');

                // Reads user input string and converts/stores it in int _candyBarId
                int.TryParse(Console.ReadLine(), out vm._candyBarId );

                // Write the result of the selection
                Console.WriteLine('\n' + vm.SelectCandy(vm._candyBarId) + '\n');
                // Shows remaining quarters and bars
                Console.WriteLine(vm.ToString() + '\n');
            }
        }
            
    }
}

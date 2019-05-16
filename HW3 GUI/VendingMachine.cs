using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{

    public class VendingMachine
    {
        // private instance variables
        public int _numQuarters, _barsVended;
        public int[] _numCandyBars;
        public string [] _candyBarNames;
        public int _candyBarId;
        public int[] _prices;

        // Public noarg constructor
        public VendingMachine()
        {
            // Set the candy bar cost in quarters.  
            //_numQuarters = 3;

            // Set initial number of candy bars.
            _numCandyBars = new int[4];
            _numCandyBars[0] = 5;
            _numCandyBars[1] = 5;
            _numCandyBars[2] = 5;
            _numCandyBars[3] = 5;

            // Set candy bar names in an array
            _candyBarNames = new string[4];
            _candyBarNames[0] = "Twix";
            _candyBarNames[1] = "Snickers";
            _candyBarNames[2] = "KitKat";
            _candyBarNames[3] = "Crunch";

            // Set candy bar prices in an array
            _prices = new int[4];
            _prices[0] = 3;
            _prices[1] = 4;
            _prices[2] = 5;
            _prices[3] = 6;
        }

        // Public methods:
        public string DepositQuarter()
        {
            // adds to the number of quarters
            _numQuarters++;

            // returns a string
            return "Quarter deposited.";
        }

        public string SelectCandy(int _candyBarId)
        {
            if (_numQuarters >= _prices[_candyBarId] && _numCandyBars[_candyBarId] > 0)
            {
                // subtracts price of candy from the number of quarters entered
                _numQuarters = _numQuarters - _prices[_candyBarId];
                // subtracts candy bar from the number of bars 
                _numCandyBars[_candyBarId]--;
                // adds to the number of bars vended
                _barsVended++;
      
                // returns a string
                return _candyBarNames[_candyBarId] + " bar dispensed";
            }
            else if (_numCandyBars[_candyBarId] > 0)
            {
                // returns a string
                return "Not enough money to buy a " + _candyBarNames[_candyBarId] + " bar.";
            }
            else
            {
                // returns a string
                return "No " + _candyBarNames[_candyBarId] + " bars left.";
            }
        }

        public override string ToString()
        {
            // returns a string
            return "Total Quarters: " + _numQuarters + " Total Bars:" + _numCandyBars[_candyBarId];
        }
    }

}

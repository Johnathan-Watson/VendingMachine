using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW3_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HW3.VendingMachine vm;

        public MainWindow()
        {
            InitializeComponent();
            // Creates a new Vending Machine
            vm = new HW3.VendingMachine();

            // shows the number of bars in machine
            txtTwix.Text = vm._numCandyBars[0].ToString();
            txtSnickers.Text = vm._numCandyBars[1].ToString();
            txtKitKat.Text = vm._numCandyBars[2].ToString();
            txtCrunch.Text = vm._numCandyBars[3].ToString();

            // converts the integers in _numQuarters into floats representing a quarters actual value
            Double _quarter = 0.25;
            Double _money = vm._numQuarters * _quarter;

        }

        // actions on Deposit button clicks
        private void btnDepositQuarter_Click(object sender, RoutedEventArgs e)
        {
            vm.DepositQuarter();

            // re-initializing
            Double _quarter = 0.25;
            Double _money = vm._numQuarters * _quarter;

            // Updates the values in the _money label
            lblCollected.Content = _money.ToString("C");
        }

        // actions on Vend button clicks
        private void btnVend_Click(object sender, RoutedEventArgs e)
        {
            // Shows whats been dispensed
            MessageBox.Show(vm.SelectCandy(vm._candyBarId));

            // re-initializing
            Double _quarter = 0.25;
            Double _money = vm._numQuarters * _quarter;

            // Updates the values in _numCandyBars text boxes
            txtTwix.Text = vm._numCandyBars[0].ToString();
            txtSnickers.Text = vm._numCandyBars[1].ToString();
            txtKitKat.Text = vm._numCandyBars[2].ToString();
            txtCrunch.Text = vm._numCandyBars[3].ToString();

            // Updates the value in the _money label
            lblCollected.Content = _money.ToString("C");

            // Updates the value in the _barsVended label
            lblBarsVended1.Content = vm._barsVended.ToString();
        }


        // actions on Twix radio button selection
        private void radTwix_Checked(object sender, RoutedEventArgs e)
        {
            // Sets _candyBarId to correspond to Twix
            vm._candyBarId = 0;
        }

        // actions on Snickers radio button selection
        private void radSnickers_Checked(object sender, RoutedEventArgs e)
        {
            // Sets _candyBarId to correspond to Snickers
            vm._candyBarId = 1;
        }

        // actions on KitKat radio button selection
        private void radKitKat_Checked(object sender, RoutedEventArgs e)
        {
            // Sets _candyBarId to correspond to KitKat
            vm._candyBarId = 2;
        }

        // actions on Crunch radio button selection
        private void radCrunch_Checked(object sender, RoutedEventArgs e)
        {
            // Sets _candyBarId to correspond to Crunch
            vm._candyBarId = 3;
        }


    }
}

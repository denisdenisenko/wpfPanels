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

namespace wpfPanels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputCatAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
            {
                try
                {
                    int inputCatAge = Int32.Parse(InputCatAge.Text);
                    string humanAge = "";
                    if (inputCatAge >= 0 && inputCatAge <= 1) 
                    {
                        humanAge = "0-15";
                        ResultTextBlock.Text = "your cat's age is " + humanAge + "age old";
                    }
                    else if (inputCatAge >=2 )
                }
                catch (Exception myException) 
                {
                    MessageBox.Show("Not available");
                }
                
            }
        }
    }
}

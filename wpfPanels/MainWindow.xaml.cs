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
        public TextBlock ResultTextBlock;
        public TextBox InputCatAge;
        public TextBlock ResultTextBlock2;



        public MainWindow()
        {
            InitializeComponent();

            Image backgroudImage = new Image()
            {
                Source = new BitmapImage(new Uri("https://ychef.files.bbci.co.uk/976x549/p07ryyyj.jpg", UriKind.RelativeOrAbsolute))
            };

            ResultTextBlock = new TextBlock()
            {
                Text = "Your cat is ",
                FontSize = 18
            };

            ResultTextBlock2 = new TextBlock()
            {
                Text = "Your cat is ",
                FontSize = 18
            };


            InputCatAge = new TextBox()
            {
                Width = 120,
                TextAlignment = TextAlignment.Center
            ,
                FontSize = 16,
                Margin = new Thickness(5, 0, 0, 0)
            };

            InputCatAge.KeyDown += InputCatAge_KeyDown;

            TextBlock userQuestion = new TextBlock()
            {
                Text = "How old is your cat>",
                FontSize = 18
            };

            StackPanel horizontalSp = new StackPanel()
            { Orientation = Orientation.Horizontal, Margin = new Thickness(1, 5, 0, 0) };

            horizontalSp.Children.Add(userQuestion);
            horizontalSp.Children.Add(InputCatAge);


            StackPanel MainVerticalStackPanel = new StackPanel();

            MainVerticalStackPanel.Children.Add(horizontalSp);
            MainVerticalStackPanel.Children.Add(ResultTextBlock);
            MainVerticalStackPanel.Children.Add(backgroudImage);
            MainVerticalStackPanel.Children.Add(ResultTextBlock2);

            myMainWindow.Content = MainVerticalStackPanel;
            
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
                        ResultTextBlock.Text = "your cat's age is " + humanAge + " age old";
                    }
                    else if (inputCatAge >= 2 && inputCatAge < 25) 
                    {
                        humanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                        ResultTextBlock.Text = "your cat's age is " + humanAge + " age old";
                    }
                    else
                        ResultTextBlock.Text = "Wrong value";

                }
                catch (Exception myException) 
                {
                    MessageBox.Show("Not available");
                }
                
            }
        }
    }
}

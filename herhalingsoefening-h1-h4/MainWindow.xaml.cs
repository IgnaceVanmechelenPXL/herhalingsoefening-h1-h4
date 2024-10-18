using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace herhalingsoefening_h1_h4
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
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("getallen uitprinten?", "print values", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                int.TryParse(startValueTextBox.Text, out int startValue);
                int.TryParse(endValueTextBox.Text, out int endValue);
                StringBuilder sb = new StringBuilder();
                while (startValue < endValue - 1)
                {
                    if (startValue % 2 == 0)
                    {
                        startValue++;
                        sb.AppendLine($"{startValue} ");
                    }
                    else
                    {
                        startValue++;
                        sb.Append($"{startValue} ");
                    }
                }
                resultTextBlock.Text = sb.ToString();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        //1) Start een nieuwe solution
        //2) 2 textboxen voor een start- en een eindgetal
        //3) bij het klikken op de START-button, verschijnt er een messagebox, met een YesNo.
        //    No -> X
        //    Yes -> Alle getallen uitprinten
        //4) print alle getallen die tussen die range zit, in een textblock
        //    alle even getallen starten op een newline

        //ex:
        //input: 1
        //input: 10

        //resultaat:
        //2 3
        //4 5
        //6 7
        //8 9
    }
}
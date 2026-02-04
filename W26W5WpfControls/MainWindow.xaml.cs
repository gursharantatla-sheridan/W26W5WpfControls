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

namespace W26W5WpfControls
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

        private void btnGetHobbies_Click(object sender, RoutedEventArgs e)
        {
            string hobbies = "";

            if (chkSinging.IsChecked == true)
                hobbies += chkSinging.Content + "\n";

            if (chkTravelling.IsChecked == true)
                hobbies += chkTravelling.Content + "\n";

            if (chkRiding.IsChecked == true)
                hobbies += chkRiding.Content + "\n";

            MessageBox.Show(hobbies);
        }

        private void btnGetCity_Click(object sender, RoutedEventArgs e)
        {
            string city = cmbCities.Text;
            MessageBox.Show(city);
        }
    }
}
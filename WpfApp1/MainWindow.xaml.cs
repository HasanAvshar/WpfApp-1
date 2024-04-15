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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Random random = new Random();
                Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                SolidColorBrush brush = new SolidColorBrush(color);
                button.Background = brush;
                MessageBox.Show("Button " + button.Background.ToString());
            }
        }
        private void Button_MouseRight(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                Title += " " + button.Content.ToString();
                MainGrid.Children.Remove(button);
            }
        }
    }
}
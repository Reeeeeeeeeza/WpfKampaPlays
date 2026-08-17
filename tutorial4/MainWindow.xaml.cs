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

namespace tutorial4
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
        bool flag = true;
        public void button_onepress(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                label_one.Content = "pressed";
            }
            else
            {
                label_one.Content = "not pressed";
            }
            flag = !flag;
        }
    }
}
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

namespace MODALpRJ
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
        public void OpenNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWin normalWin = new NormalWin();
            normalWin.Show();
        }

        public void OpenModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWin modalWin = new ModalWin();
            modalWin.ShowDialog ();
        }
    }
}
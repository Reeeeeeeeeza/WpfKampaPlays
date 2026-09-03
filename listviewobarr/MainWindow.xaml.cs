using System.Collections;
using System.Collections.ObjectModel;
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

namespace listviewobarr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            entries = new ObservableCollection<string>();
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        public void Add_btn_Click(object sender, RoutedEventArgs e)
        {
           Entries.Add(textboxx.Text);
        }
        public void Del_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        public void Clr_btn_Click(object sender, RoutedEventArgs e)
        {
        }






    }
}
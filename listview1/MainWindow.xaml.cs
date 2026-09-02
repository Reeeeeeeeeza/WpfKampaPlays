using System.Collections;
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

namespace listview1
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


        public void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            lv.Items.Add(textboxx.Text);
        }
        public void Del_btn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = lv.SelectedItems;

            var newItems = new ArrayList(selectedItems);
            foreach (var item in newItems)
            {
                lv.Items.Remove(item);
            }
        }
        public void Clr_btn_Click(object sender, RoutedEventArgs e)
        {
            lv.Items.Clear();
        }

    }
}
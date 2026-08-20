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

namespace listviewPrj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("HI lol");
            lvEntries.Items.Add("HI lsdfasfol");
            lvEntries.Items.Add("HI hhhhhhh");
        }
        private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(textBoxInput.Text);
            textBoxInput.Clear();
        }

        private void ButtonDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            var index = lvEntries.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to delete {index.Count}", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) 
            { 
                var itemLists = new ArrayList(index);
                foreach(var item in itemLists)
                {
                    lvEntries.Items.Remove(item);
                }
            }


            //lvEntries.Items.RemoveAt(index);
        }
        private void ButtonClearItem_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }


    }
}
using Microsoft.Win32;
using System.Windows;

namespace dialogeboxprj
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

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {   
            OpenFileDialog  openFileDialog = new OpenFileDialog();
            openFileDialog .Filter = "C# Source Files | *.cs";
            openFileDialog .Title = "Select a C# Source File";

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                txt_1.Text = openFileDialog.FileName;
            }
            else
            {
                txt_1.Text = "No file selected.";
            }
        }
    }
}
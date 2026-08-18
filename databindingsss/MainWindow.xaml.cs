using System.ComponentModel;
using System.Windows;

namespace databindingsss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private string boundText;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            }
        }

        public void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Button Clicked!";
        }

    }
}
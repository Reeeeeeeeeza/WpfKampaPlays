using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace customUserControlPrj
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value; 
                textBlock_one.Text = placeholder;
            }
        }


        public void onPress(object Sender, RoutedEventArgs e)
        {
            textBox_one.Clear();
        }

        public void text_inp(object Sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_one.Text))
            {
                textBlock_one.Visibility = Visibility.Visible;
            }
            else
            {                 
                textBlock_one.Visibility = Visibility.Hidden; }
            }

    }
}

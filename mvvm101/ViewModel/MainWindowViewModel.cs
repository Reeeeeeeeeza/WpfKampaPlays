using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using mvvm101.Model;
using mvvm101.MVVM;

namespace mvvm101.ViewModel
{
    internal class MainWindowViewModel: ViewModelBase
    {
        public ObservableCollection <item> Items { get; set; }
        public MainWindowViewModel() 
        {
            Items = new ObservableCollection<item>();

            Items.Add(new item { Name = "Item 1", SerialNumber = "SN001", Quantity = 10 });
            Items.Add(new item { Name = "Item 1", SerialNumber = "SN001", Quantity = 10 });

        }

        private item selectedItem;

        public item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                item selectedItem = value;
                OnPropertyChanged(); 
            }
        }


    }
}

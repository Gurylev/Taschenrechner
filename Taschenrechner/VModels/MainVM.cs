using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Taschenrechner.VModels
{
    public class MainVM : INotifyPropertyChanged
    {
        
        private int _selectedTab = 0;
        
        public ObservableCollection<ITabItemVM> TabItems
        {
            get
            {
                return _TabItems;
            }
            private set
            {
                _TabItems = value;
                OnPropertyChanged("TabItems");
            }
        }

        public int SelectedTab
        {
            get { return _selectedTab; }
            set
            {
                if (value != _selectedTab)
                {
                    _selectedTab = value;
                    OnPropertyChanged("SelectedTab");
                }
            }
        }


        public ObservableCollection<ITabItemVM> _TabItems { get; set; } = new ObservableCollection<ITabItemVM>();

        public MainVM()
        {
            TabItems.Add(new NormalVM("GMC"));
            this.SelectedTab = TabItems[0];
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }    
}

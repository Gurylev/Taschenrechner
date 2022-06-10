using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Taschenrechner.VModels;

namespace Taschenrechner.VModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public NormalTabVM NormalTabvm {get; set;}
        public MainWindowVM()
        {

            Tabs = new ObservableCollection<ITabItemVM>();
            NormalTabvm = new NormalTabVM("Обычный");
            Tabs.Add(NormalTabvm);
        }
        public ICollection<ITabItemVM> Tabs { get; }


    }    
}

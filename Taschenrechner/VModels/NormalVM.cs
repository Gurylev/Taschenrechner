﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Taschenrechner.VModels
{
    public class NormalVM : ITabItemVM, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string Header { get; set; }

        public NormalVM(string header)
        {
            Header = header;
        }
    }

    public interface ITabItemVM
    {
        string Header { get; set; }
    }
}

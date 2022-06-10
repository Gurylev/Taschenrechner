using NLog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Models
{
    public class MainModel
    {
        public ObservableCollection<TabModel> tabs { get; set; }
        public MainModel()
        {                     
        }       
    }
}

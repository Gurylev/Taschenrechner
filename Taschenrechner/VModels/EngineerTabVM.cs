using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taschenrechner.Models;

namespace Taschenrechner.VModels
{
    internal class EngineerTabVM : TabVM
    {
        private EngineerTabModel _engineertab;

        public string Header { get; set; }
        public EngineerTabVM(EngineerTabModel engineerltab)
        {
            _engineertab = engineerltab;
            Header = engineerltab.Header;
        }
    }
}

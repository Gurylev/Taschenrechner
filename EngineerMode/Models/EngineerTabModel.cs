using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerMode.Models
{
    public class EngineerTabModel
    {
        public string Header { get; set; }
        public EngineerTabModel(string Header)
        {
            this.Header = Header;
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Taschenrechner.VModels
{
    public class NormalTabVM : TabVM
    {
        public string Name { get; set; }

        public NormalTabVM(string name)
        {
            Name = name;
        }

    }

   
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Taschenrechner.MVVMBase;

namespace Taschenrechner.VModels
{
    public class TabVM : VMBase
    {       
        public string Header { get; set; }
        public string textLabel { get; set; }
    }   
}

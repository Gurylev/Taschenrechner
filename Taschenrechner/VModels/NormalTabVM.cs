using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taschenrechner.Models;
using Taschenrechner.MVVMBase;
using System.Windows.Controls;
using System.Data;

namespace Taschenrechner.VModels
{
    public class NormalTabVM : TabVM
    {
        private NormalTabModel _normaltab;
        public NormalTabVM(NormalTabModel normaltab)
        {
            _normaltab = normaltab;
            Header = normaltab.Header;
            ClickCommand = new RelayCommand<string>(ClickBtn);
        }

        public ICommand ClickCommand { get; }

        /// <summary>
        /// Нажатие на кнопки интерфейса калькулятора
        /// </summary>
        /// <param name="obj"></param>
        private void ClickBtn(string cmd)
        {
            //logger.Info("Нажатие на кнопку: " + str);

            if (cmd == "AC")
            {
                textLabel = "";
            }
            else if (cmd == "=")
            {
                try
                {
                    string value = new DataTable().Compute(textLabel, null).ToString();
                    textLabel = value;
                }
                catch (Exception ex)
                {
                   // logger.Error(ex.ToString());
                }
            }
            else
            {
                textLabel += cmd;
            }
            this.RaisePropertyChanged("textLabel");
        }       
    }
}

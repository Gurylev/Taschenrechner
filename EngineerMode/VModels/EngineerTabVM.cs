using EngineerMode.Base;
using EngineerMode.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EngineerMode.VModels
{
    internal class EngineerTabVM : VMBase
    {
        public Logger Log { get; set; }
        public string Header { get; set; }
        public string textLabel { get; set; }
        private EngineerTabModel _engineertab;
        public EngineerTabVM(EngineerTabModel engineertab, Logger log)
        {
            _engineertab = engineertab;
            Header = engineertab.Header;
            ClickCommand = new RelayCommand<string>(ClickBtn);
            Log = log;
        }

        public ICommand ClickCommand { get; }

        /// <summary>
        /// Нажатие на кнопки интерфейса калькулятора неженерный вид
        /// </summary>
        /// <param name="obj"></param>
        private void ClickBtn(string cmd)
        {
            Log.Info("Нажатие на кнопку: " + cmd);

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
                    Log.Error(ex.ToString());
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using NLog;
using Taschenrechner.MVVMBase;
using Taschenrechner.Models;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using EngineerMode.Models;

namespace Taschenrechner.VModels
{
    public class MainWindowVM : VMBase
    {
        //Логгирование событий
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private CompositionContainer _container;

        public MainWindowVM()
        {
            //Конфигурирование NLog
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterLevel(LogLevel.Info).WriteToConsole("${longdate} ${level} ${message}");
                builder.ForLogger().FilterMinLevel(LogLevel.Error).WriteToFile("${basedir}/logs/${shortdate}.log", "${longdate} ${level} ${message} ${exception} ");
            });

            logger.Info("Приложение запущено!");

            Tabs = new ObservableCollection<ITabVM>();
            Tabs.Add(new NormalTabVM(new NormalTabModel("Обычный"), logger));
            Tabs.Add(new Enginer(new EngineerTabModel("Инженерный"), logger));
            ClickCommand = new RelayCommand<object>(CloseCommand);

        }
        public ICollection<ITabVM> Tabs { get; }
        public ICommand ClickCommand { get; }

        /// <summary>
        /// Кнопка закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCommand(object sender)
        {
            Window win = sender as Window;
            logger.Info("Приложение закрывается!");
            win.Close();
        }

        /// <summary>
        /// Костыльно, но с MEF не разобрался
        /// </summary>
        public class Enginer : EngineerMode.VModels.EngineerTabVM, ITabVM
        {
            public Enginer(EngineerTabModel engineertab, Logger log) : base(engineertab, log)
            {
            }
        }


    }
}

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

namespace Taschenrechner.VModels
{
    public class MainWindowVM : VMBase
    {
        public 
        //Логгирование событий
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindowVM()
        {
            //Конфигурирование NLog
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterLevel(LogLevel.Info).WriteToConsole("${longdate} ${level} ${message}");
                builder.ForLogger().FilterMinLevel(LogLevel.Error).WriteToFile("${basedir}/logs/${shortdate}.log", "${longdate} ${level} ${message} ${exception} ");
            });

            #region Инициализация всех кнопок

            //foreach (UIElement el in Normal.Children)
            //{
            //    if (el is Button)
            //    {
            //        ((Button)el).Click += Button_Click;
            //    }
            //}

            //foreach (UIElement el2 in Engineer.Children)
            //{
            //    if (el2 is Button)
            //    {
            //        ((Button)el2).Click += Button2_Click;
            //    }
            //}

            #endregion

            logger.Info("Приложение запущено!");

            Tabs = new ObservableCollection<TabVM>();
            Tabs.Add(new NormalTabVM(new NormalTabModel("Обычный")));
        }
        public ICollection<TabVM> Tabs { get; }

        ///// <summary>
        ///// Кнопка закрытия приложения
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Close_Click(object sender, RoutedEventArgs e)
        //{
        //    logger.Info("Приложение закрывается!");
        //    this.Close();
        //}


    }
}

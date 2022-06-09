using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NLog;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Логгирование событий
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Попытки MVVM
        /// </summary>
        private VModels.MainVM _mainvm;
        public VModels.MainVM MainVM
        {
            get
            {
                return _mainvm;
            }
            set { _mainvm = value; }
        }

        public MainWindow()
        {
            //Инициализация основного VM
            _mainvm = new VModels.MainVM();
            DataContext = _mainvm;
            
            //Конфигурирование NLog
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterLevel(LogLevel.Info).WriteToConsole("${longdate} ${level} ${message}");
                builder.ForLogger().FilterMinLevel(LogLevel.Error).WriteToFile("${basedir}/logs/${shortdate}.log", "${longdate} ${level} ${message} ${exception} ");
            });

            InitializeComponent();
            
            logger.Info("Приложение запущено!");

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
        }

        /// <summary>
        /// Нажатие на кнопки интерфейса калькулятора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string str = (string)((Button)e.OriginalSource).Content;

        //    logger.Info("Нажатие на кнопку: " + str);
            

        //    if (str == "AC")
        //        textLabel.Text = "";
        //    else if (str == "=")
        //    {
        //        try
        //        {
        //            string value = new DataTable().Compute(textLabel.Text, null).ToString();
        //            textLabel.Text = value;
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.Error(ex.ToString());
        //        }
        //    }
        //    else
        //        textLabel.Text += str;
        //}

        /// <summary>
        /// Ввод с клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    string[] Symbols = new string[] { "Add", "Subtract", "Divide", "Multiply" };
        //    string str = e.Key.ToString();

        //    foreach (var ch in str)
        //    {
        //        if (char.IsDigit(ch))
        //        {
        //            logger.Info("Нажатие на кнопку клавиатуры: " + ch);

        //            textLabel.Text += ch;
        //        }
        //    }


        //    if (Symbols.Contains(str))
        //    {
        //        logger.Info("Нажатие на кнопку клавиатуры: " + str);

        //        switch (str)
        //        {
        //            case "Add":
        //                textLabel.Text += '+';
        //                break;
        //            case "Subtract":
        //                textLabel.Text += '-';
        //                break;
        //            case "Multiply":
        //                textLabel.Text += '*';
        //                break;
        //            case "Divide":
        //                textLabel.Text += '/';
        //                break;
        //        }
        //    }
        //    if (e.Key == Key.Enter)
        //    {
        //        try
        //        {
        //            logger.Info("Нажатие на кнопку клавиатуры: Enter");

        //            string value = new DataTable().Compute(textLabel.Text, null).ToString();
        //            textLabel.Text = value;
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.Error(ex.ToString());
        //        }
        //    }
        //    if (e.Key == Key.Back)
        //    {
        //        logger.Info("Нажатие на кнопку клавиатуры: Backspace");
        //        textLabel.Text = "";
        //    }
        //}

        /// <summary>
        /// Кнопка закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("Приложение закрывается!");
            this.Close();
        }

        /// <summary>
        /// Возможность перемещать окно не за рамку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
            

        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    string str = (string)((Button)e.OriginalSource).Content;

        //    if (str == "AC")
        //        textLabel2.Text = "";
        //    else if (str == "=")
        //    {
        //        string value = new DataTable().Compute(textLabel2.Text, null).ToString();
        //        textLabel2.Text = value;
        //    }
        //    else
        //        textLabel2.Text += str;
        //}
    }
}

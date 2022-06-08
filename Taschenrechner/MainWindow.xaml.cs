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
        //Логирование событий
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        bool keycode = false;
        public KeyGesture Multiply;
        public KeyGesture Divide;
        public KeyGesture Result;


        public MainWindow()
        {
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToConsole("${longdate} ${level} ${message} ${exception} ");
            });
            InitializeComponent();
            
            logger.Info("Приложение запущено!");

            #region Инициализация всех кнопок
            foreach (UIElement el in Normal.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }

            //foreach (UIElement el2 in Engineer.Children)
            //{
            //    if (el2 is Button)
            //    {
            //        ((Button)el2).Click += Button2_Click;
            //    }
            //}
            #endregion
            KeyGesture Multiply = new KeyGesture(Key.Oem8, ModifierKeys.Shift);
            KeyGesture Divide = new KeyGesture(Key.OemQuestion, ModifierKeys.Shift);
            KeyGesture Result = new KeyGesture(Key.OemPlus, ModifierKeys.Shift);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            logger.Info("Нажатие на кнопку: " + str);

            if (str == "AC")
                textLabel.Text = "";
            else if (str == "=")
            {
                try
                {
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                }
                catch (Exception ex)
                {
                    logger.Error(ex.ToString());
                }
            }
            else
                textLabel.Text += str;
        }



        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            string[] Symbols = new string[] { "OemMinus", "OemPlus" };
            string str = e.Key.ToString();
            if (char.IsDigit(str[1]))
            {
                textLabel.Text += str[1];
            }

            if (keycode & Symbols.Contains(str))
            {
                switch (str)
                {
                    
                }
            }
            else if(Symbols.Contains(str))
            {
                textLabel.Text += str;
            }


            if (e.Key == Key.LeftShift)
            {
                keycode = true;
            }
            
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.Key == Key.LeftShift)
            {
                keycode = false;
            }
        }

        private void OnClickKeyCode(object sender, RoutedEventArgs e)
        {

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

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
using Taschenrechner.Logger;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (_ = new EventLogger("Info", "Приложение запущено!")) ;
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

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

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
                    using (_ = new EventLogger("Debug", ex.ToString()));
                }
            }
            else
                textLabel.Text += str;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

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

namespace Taschenrechner.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        /// <summary>
        /// Попытки MVVM
        /// </summary>
        private VModels.MainWindowVM _mainvm;
        public VModels.MainWindowVM MainVM
        {
            get
            {
                return _mainvm;
            }
            set 
            { 
                _mainvm = value;
            }
        }

        public MainWindow()
        {
            //Инициализация основного VM
            MainVM = new VModels.MainWindowVM();
            DataContext = MainVM;                                  
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Models
{
    public class NormalTabModel
    {
        public string Name { get; set; }

        public NormalTabModel(string name)
        {
            Name = name;
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
    }
}

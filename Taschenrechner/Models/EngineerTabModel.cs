using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Models
{
    public class EngineerTabModel : TabModel
    {

        public EngineerTabModel(string Header)
        {
            this.Header = Header;
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

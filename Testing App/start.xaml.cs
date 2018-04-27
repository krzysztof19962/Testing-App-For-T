using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Testing_App
{
    
    /// <summary>
    /// Interaction logic for start.xaml
    /// </summary>
    public partial class start : Window
    {
        public int liczbapytanint = 0;
        public start()
        {
            InitializeComponent();
        }

        private void liczbapytan(object sender, RoutedEventArgs e)
        {
            //Int32.Parse(TextBoxzliczbapytan.Text);
            liczbapytanint = Int32.Parse(textBoxzliczbapytan.Text);
            Window1 okno1 = new Window1(liczbapytanint);
            okno1.Show();
            this.Close();

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(int liczba)
        {
            
            InitializeComponent();
           createformula(liczba);
        }

        public IList<StackPanel> panele; 
        public IList<Label> pytania;
        public IList<TextBox> formularzpytania;
        public IList<TextBox> odpowiedzi1;
        public IList<TextBox> odpowiedzi2;
        public IList<TextBox> odpowiedzi3;
        public IList<RadioButton> radio1;
        public IList<RadioButton> radio2;
        public IList<RadioButton> radio3;
        public void createformula(int liczba)
        {
            pytania = new List<Label>();
            formularzpytania = new List<TextBox>();
            for (int i = 0; i < liczba; i++)
            {
                StackPanel panel = new StackPanel();
                TextBox pytanie = new TextBox();
                RadioButton radiop = new RadioButton();
                RadioButton radiod = new RadioButton();
                RadioButton radiot = new RadioButton();
                TextBox odp1 = new TextBox(); 
                TextBox odp2 = new TextBox();
                TextBox odp3 = new TextBox();
                odp1.Width = 300;
                odp2.Width = 300;
                odp3.Width = 300;
                odp1.Text = "1.";
                odp2.Text = "2.";
                odp3.Text = "3.";
            
                radiop.Content = odp1;
                radiod.Content = odp2;
                radiot.Content = odp3;

                string LP;
                LP = (i+1).ToString();
                pytanie.Text = LP+"Udalo sie";
            
                StackPanel1.Children.Add(pytanie);

                panel.Children.Add(radiop);
                panel.Children.Add(radiod);
                panel.Children.Add(radiot);
                StackPanel1.Children.Add(panel);

            }
        }

    }
}

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
                // Important stuff
                //StackPanel1.Children.Add(new CheckBox());
                TextBox pytanie = new TextBox();
               // ScrollViewer1.Content += pytanie;
                pytanie.Text = "Udalo sie";
               // StackPanel1.Children += pytanie;
                StackPanel1.DataContext = pytanie.DataContext;

                // Label pytanie = new Label();
                //  RadioButton radioguzik = new RadioButton();
                //  radioguzik.Content = pytanie.Content;
            }
        }

    }
}

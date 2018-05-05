using System;
using System.Collections.Generic;
using System.IO;
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
        private int dupa;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(int liczba)
        {
            dupa = liczba;
            InitializeComponent();
           createformula(liczba);
        }

        
        
        public IList<StackPanel> panele = new List<StackPanel>(); 
        public IList<TextBox> formularzpytania;
        public IList<TextBox> odpowiedzi1; 
        public IList<TextBox> odpowiedzi2;
        public IList<TextBox> odpowiedzi3; 
        public IList<RadioButton> radio1;
        public IList<RadioButton> radio2; 
        public IList<RadioButton> radio3; 
        public void createformula(int liczba)
        {

            
            formularzpytania = new List<TextBox>(liczba);

            odpowiedzi1 = new List<TextBox>(liczba);
            odpowiedzi2 = new List<TextBox>(liczba);
            odpowiedzi3 = new List<TextBox>(liczba);

            radio1 = new List<RadioButton>(liczba);
            radio2 = new List<RadioButton>(liczba);
            radio3 = new List<RadioButton>(liczba);


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
               // radiop.Checked = 

                //radiop.Checked = radiopIsChecked();
                //radiop.AddHandler(radiopIsChecked());

                odp1.Width = 300;
                odp2.Width = 300;
                odp3.Width = 300;
                odp1.Text = "1.";
                odp2.Text = "2.";
                odp3.Text = "3.";
            
                radiop.Content = odp1;
                radiod.Content = odp2;
                radiot.Content = odp3;

                
              //if (radiop.IsChecked == true || radiod.IsChecked == true || radiot.IsChecked==true)
             //   {
                    // File plik = new File()
                    //   FileStream plik = new FileStream("F:textfile.txt", 1024);
                    // plik.Write(pytanie.Text);
                  
            //  }

                string LP;
                LP = (i+1).ToString();
                pytanie.Text = LP+"Udalo sie";
            
                StackPanel1.Children.Add(pytanie);

                panel.Children.Add(radiop);
                panel.Children.Add(radiod);
                panel.Children.Add(radiot);
                StackPanel1.Children.Add(panel);
              //  panele.Add(panel);
                // waiting for confirming button ?]
                formularzpytania.Add(pytanie);
                odpowiedzi1.Add(odp1);
                odpowiedzi2.Add(odp2);
                odpowiedzi3.Add(odp3);
                radio1.Add(radiop);
                radio2.Add(radiod);
                radio3.Add(radiot);
            }
           
        }

        private void radiopIsChecked()
        {

        }

        private void zatwierdzClick(object sender, RoutedEventArgs e)
        {
            var seed = System.DateTime.Now.Millisecond;
            int los;
            TextWriter tw = File.CreateText(@"F:\output.txt");
            System.Random x = new Random(seed);
            los = x.Next(1, 100);
            tw.WriteLine("Pytania z testu ");

            for (int i = 0; i < dupa; i++)
            {
                tw.WriteLine(formularzpytania[i].Text);
                tw.WriteLine(odpowiedzi1[i].Text);
                tw.WriteLine(odpowiedzi2[i].Text);
                tw.WriteLine(odpowiedzi3[i].Text);
                
            }

           

            for (int y = 0; y < dupa; y++)
            {
                
                if (radio1[y].IsChecked==true)
                {
                    los = x.Next(1, 100);
                    los = los * 13 + 1;
                    tw.WriteLine(los.ToString());
                }

                if (radio2[y].IsChecked == true)
                {
                    los = x.Next(1, 100);
                    los = los * 13 + 2;
                    tw.WriteLine(los.ToString());
                }

                if (radio3[y].IsChecked == true)
                {
                    los = x.Next(1, 100);
                    los = los * 13 + 3;
                    tw.WriteLine(los.ToString());
                }
               // tw.WriteLine(jeden, Encoding.UTF8);
            }
        
        
            Console.WriteLine("Text created");
            //something
            tw.Close();
            
            Console.WriteLine(Console.Read());
            
        }
    }
}

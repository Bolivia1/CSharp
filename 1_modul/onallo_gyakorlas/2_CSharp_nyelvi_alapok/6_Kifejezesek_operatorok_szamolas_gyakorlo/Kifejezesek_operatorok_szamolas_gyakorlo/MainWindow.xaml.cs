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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorNamespace;

namespace Kifejezesek_operatorok_szamolas_gyakorlo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Muvelet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool helyesATipp = false;

            int szam1 = int.Parse(this.szam1.Text);
            int szam2 = int.Parse(this.szam2.Text);
            int eredmeny = int.Parse(this.eredmeny.Text);
            
            string muveletiJel = (string)(cmbMuvelet.SelectedValue as ComboBoxItem).Content;

            Calculator calc = new Calculator();       
            helyesATipp = calc.Ellenorzes(szam1, szam2, muveletiJel, eredmeny);

            string uzenet = helyesATipp ? "Az eredmény helyes" : "Az eredmény helytelen";
            MessageBox.Show(uzenet);
        }

        
    }
}

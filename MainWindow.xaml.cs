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

namespace pr3_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBox_1.Text = "Метал";
            Radio_1.IsChecked = true;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double material = 0;
            switch (ComboBox_1.Text)
            { 
                case "Метал": material = 0.05; break;
                case "Дерево": material = 0.25; break;
                case "Металопластик": material = 0.15; break;
            }
            Label_1.Content = "Вартість : "
                + ((Convert.ToDouble(TextBox_1.Text)
                * Convert.ToDouble(TextBox_2.Text))
                * (material
                + (0.05 * Convert.ToDouble((bool)Radio_2.IsChecked)))
                + (35 * Convert.ToDouble((bool)CheckBox_1.IsChecked)))
                + " грн.";
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

 

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
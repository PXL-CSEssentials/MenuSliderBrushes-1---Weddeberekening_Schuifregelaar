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

namespace MenuSliderBrushes_1___Weddeberekening_Schuifregelaar
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

        private void salarySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double taxes;
            // Waarde inlezen van trackbar.
            double salary = salarySlider.Value;

            // Belastingen berekenen.
            if (salary < 10000)
            {
                taxes = 0;
            }
            else if (salary < 50000)
            {
                taxes = salary * 0.2;
            }
            else
            {
                taxes = salary * 0.9;
            }
            // Belasting toekennen aan label.
            taxesTextBox.Text = $"{taxes:c}";
        }
    }
}

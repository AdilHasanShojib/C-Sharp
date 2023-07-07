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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person()
        {
            Name = "Test",
            Age = 20
        };
       
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string persondata= $"{p.Name} is {p.Age} years old";
            MessageBox.Show(persondata);
        }
    }
}

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

namespace ListDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    { 


        public List<Person> People { get; set; } = new List<Person>
        {
            new Person {Name="Shojib" ,Age=24},
             new Person {Name="Sani" ,Age=20},
              new Person {Name="Tisha" ,Age=18},




        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ListBoxPeople.SelectedItems; 
            foreach (Person person in selectedItem)
            {

                MessageBox.Show(person.Name);
            }

        }
    }
}

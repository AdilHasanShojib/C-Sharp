using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace LINQ_Basic_Part__2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudenLINQDataContext context;
        public MainWindow()
        {




            string ConnectionString= ConfigurationManager.ConnectionStrings["LINQ_Basic_Part__2.Properties.Settings.StudentInventoryConnectionString"].ConnectionString;
            InitializeComponent();

            context = new StudenLINQDataContext(ConnectionString);

            ShowAll();



        }


        public void ShowAll()
        {

            var studentFromData = from Student in context.Students where Student.Name == "Tisha" select Mapstudents(Student);

            MyData.ItemsSource = studentFromData;

        }

        private object Mapstudents(Student student)
        {

            return new
            {
                StudentName = student.Name,
                StudentUniversity = student.University.Name,
                Gender = student.Gender,


        };


        }




    }



}

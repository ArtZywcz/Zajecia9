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

namespace Zajecia9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentView view = new StudentView();
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = view;
            listBox1.ItemsSource = view.List.Students;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            tbId.Text = "";
            tbName.Text = "";
            tbSurname.Text = "";
            cBirthday.SelectedDate = null;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            view.List.Students.Add(new Student
            {
                id = int.Parse(tbId.Text),
                name = tbName.Text,
                surName = tbSurname.Text,
                birthday = (DateTime)cBirthday.SelectedDate
            }) ;
            

            //view = new StudentView();
            this.DataContext = view;
            listBox1.ItemsSource = view.List.Students;

            btnReset_Click(sender, e);
        }
    }
}

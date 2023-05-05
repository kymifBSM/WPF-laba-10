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

namespace WPF_laba10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string sName;
        public string sMark;

        public class Student
        {
            public string fullname { get; set; }
            public string zachetFullName { get; set; }
            public string neattestFullName { get; set; }
            public string marks { get; set; }
        }

        private void Zachet(object sender, RoutedEventArgs e)
        {
            sName = name.Text;
            sMark = mark.Text;

            this.studentList.Items.Add(new Student { zachetFullName = sName, marks = sMark});
        }

        private void NeZachet(object sender, RoutedEventArgs e)
        {
            sName = name.Text;

            this.studentList.Items.Add(new Student { neattestFullName = sName });
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            sName = name.Text;

            this.studentList.Items.Add(new Student { fullname = sName });
        }

        private void Click_Second_Column(object sender, MouseButtonEventArgs e)
        {
            string selectedStudent = (sender as TextBlock).DataContext.ToString();
            studentList.Items.Remove(selectedStudent);
            studentList.Items.Add(new Student { fullname = selectedStudent });
            
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            while (studentList.Items.Count > 0)
            {
                studentList.Items.RemoveAt(0);
            }
        }
    }
}

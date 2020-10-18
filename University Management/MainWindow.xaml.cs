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

using System.Windows.Threading;
using System.Diagnostics;
using MahApps.Metro;
using University_Management.Properties;



namespace University_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public int log = 0;
        public MainWindow()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Start();
            InitializeComponent();            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            txt_clock.Text = string.Format("{0:h:mm tt}", DateTime.Now);
        }

        //Login Starts
        private void btn_student_click(object sender, RoutedEventArgs e)
        {
            login log = new login();
            this.Close();
            log.Title = "Student Login";
            log.Show();                        
        }

        private void btn_admin_click(object sender, RoutedEventArgs e)
        {
            login log = new login();
            this.Close();
            log.Title="Administration Login";
            log.new_account.Visibility= Visibility.Hidden;
            log.new_account.Content = "New User? Register";
            log.Show();                       
        }

        private void btn_faculty_click(object sender, RoutedEventArgs e)
        {
            login log = new login();
            this.Close();
            log.Title = "Faculty Login";
            log.new_account.IsEnabled = false;
            log.new_account.Content = "New User? Register";
            log.Show();              
        }
    }
}

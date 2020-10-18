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
using System.Windows.Shapes;

using System.Windows.Threading;
using System.Diagnostics;
using MahApps.Metro;
using System.Data.SqlClient;

namespace University_Management
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login
    {
        public int log = 0;
        public login()
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

        private void btn_cancel_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
            
        }

        private void btn_newstudent_click(object sender, RoutedEventArgs e)
        {
            new_student_account ns = new new_student_account();
            this.Close();
            ns.Show();
        }

        private void btn_click_login(object sender, RoutedEventArgs e)
        {


            login_check();

          
        }
        private void login_check()
        {
            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.login";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                if (id.Text == read[0].ToString() && password.Password == read[1].ToString()&& "summer" == read[2].ToString())
                {
                    MessageBox.Show("Hello " + read[0] + " \nWelcome to NWU Student Portal", "Student Portal Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                    //   MainWindow mw = new MainWindow();
                    user_info.user = id.Text;
                    user_info.pass = password.Password;
                    user_info.type = "summer";
                    student_portal stdnt_prtl = new student_portal();
                    stdnt_prtl.Show();
                    this.Close();
                }
                if (id.Text == read[0].ToString() && password.Password == read[1].ToString() && "spring14" == read[2].ToString())
                {
                    MessageBox.Show("Hello " + read[0] + " \nWelcome to NWU Student Portal", "Student Portal Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                    //   MainWindow mw = new MainWindow();
                    user_info.user = id.Text;
                    user_info.pass = password.Password;
                    user_info.type = "spring14";
                    student_portal stdnt_prtl = new student_portal();
                    stdnt_prtl.Show();
                    this.Close();
                }
                if (id.Text == read[0].ToString() && password.Password == read[1].ToString())
                {
                    MessageBox.Show("Hello " + read[0] + " \nWelcome to NWU Admin Portal", "Student Portal Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                    //   MainWindow mw = new MainWindow();
                    user_info.user = id.Text;
                    user_info.pass = password.Password;
                    user_info.type = "spring14";
                    student_portal stdnt_prtl = new student_portal();
                    stdnt_prtl.Show();
                    this.Close();
                }

            }
        }

    }
}

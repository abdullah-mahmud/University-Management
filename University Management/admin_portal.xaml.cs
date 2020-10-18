using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace University_Management
{
    /// <summary>
    /// Interaction logic for admin_portal.xaml
    /// </summary>
    public partial class admin_portal
    {
        public admin_portal()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Start();
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        private void add_notice_click(object sender, RoutedEventArgs e)
        {
            noticeboard notice_board = new noticeboard();
            notice_board.Show();
            this.Close();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            txt_clock.Text = string.Format("{0:h:mm tt}", DateTime.Now);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = -canMain.ActualWidth;
            doubleAnimation.To = -txt_receive_msg.ActualWidth;
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimation.Duration = new Duration(TimeSpan.Parse("0:0:10"));
            txt_receive_msg.BeginAnimation(Canvas.BottomProperty, doubleAnimation);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // scrollviewer.ScrollToBottom();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            // dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            dispatcherTimer.Start();

        }
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //scrollviewer.ScrollToBottom();

            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

            SqlConnection sqlcon = new SqlConnection(connectionstring);


            string commandstring = "select * from dbo.notice_board";



            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcon.Open();

            SqlDataReader read = sqlcmd.ExecuteReader();

            txt_receive_msg.Text = "";
            while (read.Read())
            {
                //scrollviewer.ScrollToBottom();
                txt_receive_msg.Text += "Message: \n" + read["message"].ToString() + "\n";
                txt_receive_msg.Text += "Time :" + read["msgdate"].ToString() + "\n\n";

            }

            sqlcon.Close();


        }
    }
}

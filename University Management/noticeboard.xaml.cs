using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace University_Management
{
    /// <summary>
    /// Interaction logic for noticeboard.xaml
    /// </summary>
    public partial class noticeboard 
    {
        public noticeboard()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            scrollviewer.ScrollToBottom();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }



        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                //scrollviewer.ScrollToBottom();
                string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                string commandstring = "select * from dbo.notice_board ";
                SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);

                sqlcon.Open();

                SqlDataReader read = sqlcmd.ExecuteReader();

                txt_receive_msg.Text = "";

                while (read.Read())
                {
                    //scrollviewer.ScrollToBottom();                  
                    txt_receive_msg.Text += "Message: \n" + read["message"].ToString() + "\n";
                    txt_receive_msg.Text += "Time : " + read["msgdate"].ToString() + "\n";
                    txt_receive_msg.Text += "................................................................................................................................................................................................\n\n";


                }

                sqlcon.Close();
            }
            catch
            {

            }

        }

        private void btn_send_msg_click(object sender, RoutedEventArgs e)
        {
            



            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into dbo.notice_board(msgdate,message) values(@msgdate,@message)", sqlcon);




            cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = txt_send_msg.Text;
            cmd.Parameters.Add("@msgdate", SqlDbType.DateTime).Value = DateTime.Now;
     
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            sqlcon.Close();
            //MessageBox.Show("Your Message Has Sent Successfully", "Message Sent Cinfirmation", MessageBoxButton.OK, MessageBoxImage.Warning);
            scrollviewer.ScrollToBottom();

        }




        private void focus(object sender, RoutedEventArgs e)
        {
            txt_send_msg.Text = "";
        }

        private void keypress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                


                string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(connectionstring);

                SqlCommand cmd = new SqlCommand("insert into dbo.notice_board(msgdate,message) values(@msgdate,@message)", sqlcon);




                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = txt_send_msg.Text;
                cmd.Parameters.Add("@msgdate", SqlDbType.DateTime).Value = DateTime.Now;
               
                sqlcon.Open();
                int rows = cmd.ExecuteNonQuery();
                sqlcon.Close();
                scrollviewer.ScrollToBottom();
                e.Handled = true;



            }

        }


        private void back_button_click(object sender, RoutedEventArgs e)
        {
            admin_portal admin_portal = new admin_portal();
            admin_portal.Show();
            this.Close();
        }

        private void clear_button_click(object sender, RoutedEventArgs e)
        {

            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("delete  from dbo.notice_board", sqlcon);




            //cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = txt_send_msg.Text;
          //  cmd.Parameters.Add("@msgdate", SqlDbType.DateTime).Value = DateTime.Now;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            sqlcon.Close();
        }


    }
}

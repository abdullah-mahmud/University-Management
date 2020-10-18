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
    /// Interaction logic for group_chat.xaml
    /// </summary>
    public partial class group_chat
    {
        public group_chat()
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
                string commandstring = "select * from dbo.dash_table where group_type=@type order by msgdate";
                SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);

               
               
                sqlcmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_info.user;
                sqlcmd.Parameters.Add("@type", SqlDbType.VarChar).Value = user_info.type;

                sqlcon.Open();

                SqlDataReader read = sqlcmd.ExecuteReader();

                txt_receive_msg.Text = "";
            
                while (read.Read())
                {
                    //scrollviewer.ScrollToBottom();
                    txt_receive_msg.Text += "From: " + read["userid"].ToString() + "\n";
                    txt_receive_msg.Text += "Message: \n" + read["message"].ToString() + "\n";
                    txt_receive_msg.Text += "Time : " + read["msgdate"].ToString()+"\n";
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
            string t = "";
            if (user_info.type=="summer")
                t = "summer";
            else if (user_info.type == "spring14")
                t = "spring14";



            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into dbo.dash_table(userid,msgdate,message,group_type) values(@user_id,@msgdate,@message,@grouptype)", sqlcon);




            cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = txt_send_msg.Text;
            cmd.Parameters.Add("@msgdate", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_info.user;
            cmd.Parameters.Add("@grouptype", SqlDbType.VarChar).Value = t;

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
                string t = "";
                if (user_info.type == "summer")
                    t = "summer";
                else if (user_info.type == "spring14")
                    t = "spring14";



                string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(connectionstring);

                SqlCommand cmd = new SqlCommand("insert into dbo.dash_table(userid,msgdate,message,group_type) values(@user_id,@msgdate,@message,@grouptype)", sqlcon);




                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = txt_send_msg.Text;
                cmd.Parameters.Add("@msgdate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_info.user;
                cmd.Parameters.Add("@grouptype", SqlDbType.VarChar).Value = t;

                sqlcon.Open();
                int rows = cmd.ExecuteNonQuery();
                sqlcon.Close();
                scrollviewer.ScrollToBottom();
                e.Handled = true;



            }

        }

       
        private void back_button_click(object sender, RoutedEventArgs e)
        {
            Communicate com = new Communicate();
            com.Show();
            this.Close();
        }
       
    }
}

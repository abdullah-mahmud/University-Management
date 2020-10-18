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
using System.Data;
using System.Data.SqlClient;

namespace University_Management
{
    /// <summary>
    /// Interaction logic for new_student_account.xaml
    /// </summary>
    public partial class new_student_account
    {
        public static int log = 0;
        //public string gen,mar;
        BitmapImage bitmapimage;
        public new_student_account()
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

        private void btn_browse_pic_click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openfile = new System.Windows.Forms.OpenFileDialog();
            bitmapimage = new BitmapImage();
            bitmapimage.BeginInit();
            openfile.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png|all files|*.*";
            System.Windows.Forms.DialogResult res = openfile.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                bitmapimage.StreamSource = System.IO.File.OpenRead(openfile.FileName);
                bitmapimage.EndInit();
                student_image.Source = bitmapimage;
                //  image.Source = new BitmapImage(new Uri(openfile.FileName));
            }
        }

        

        //main codes for this window starts here

        
        private void permanent_checked(object sender, RoutedEventArgs e)
        {
            txt_parmanent_address.Text = txt_present_address.Text;
            
        }
        

        //Submit Button Click
        private void btn_submit_click(object sender, RoutedEventArgs e)
        {




            string connectionstring = @"Data Source=TAKI;Initial Catalog=Universiy_Management;Integrated Security=True";
                    SqlConnection sqlcon = new SqlConnection(connectionstring);

                    SqlCommand cmd = new SqlCommand("insert into dbo.new_student(user_id,password) values(@user,@pass)", sqlcon);
                    //   string commandstring = "insert into dbo.student(ID,Name,photo) values(@id,@name,@im)";

                    //  
                    /*cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
                    cmd.Parameters.Add("@father", SqlDbType.VarChar).Value = txtfather.Text;
                    cmd.Parameters.Add("@present", SqlDbType.VarChar).Value = txtpresentaddress.Text;
                    cmd.Parameters.Add("@parmanent", SqlDbType.VarChar).Value = parmenent;
                    cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dob.SelectedDate.Value.ToShortDateString();
                    cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = gen;
                    cmd.Parameters.Add("@m", SqlDbType.VarChar).Value = mar;
                    cmd.Parameters.Add("@term", SqlDbType.VarChar).Value = semester.SelectedValue.ToString();
                    cmd.Parameters.Add("@year", SqlDbType.Int).Value = int.Parse(session_year.SelectedValue.ToString());
                    cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = department.SelectedValue.ToString();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(student_id.Text);
                    cmd.Parameters.Add("@im", SqlDbType.Image).Value = imageData;*/
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txt_user_id.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = user_password.Text;
                    //cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = txt_mobile.Text;
                    //     +int.Parse(tbid.Text.ToString()) + ",'" + tbname.Text.ToString() + "'," + imageData + ")";
                    sqlcon.Open();
                    int rows = cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    /*SqlCommand cmd2 = new SqlCommand("insert into dbo.login(user_id,password,group_type) values(@user2,@pass2,@type2)", sqlcon);
                    //   string commandstring = "insert into dbo.student(ID,Name,photo) values(@id,@name,@im)";

                    cmd2.Parameters.Add("@user2", SqlDbType.VarChar).Value = txt_user_id.Text;
                    cmd2.Parameters.Add("@pass2", SqlDbType.VarChar).Value = user_password.Text;
                    cmd2.Parameters.Add("@type2", SqlDbType.VarChar).Value = "summer";*/
                    SqlCommand cmd2 = new SqlCommand("insert into dbo.login(user_id,password,group_type) values(@user2,@pass2,@type2)", sqlcon);
                    //   string commandstring = "insert into dbo.student(ID,Name,photo) values(@id,@name,@im)";

                    cmd2.Parameters.Add("@user2", SqlDbType.VarChar).Value = txt_user_id.Text;
                    cmd2.Parameters.Add("@pass2", SqlDbType.VarChar).Value = user_password.Text;
                    cmd2.Parameters.Add("@type2", SqlDbType.VarChar).Value = "spring14";
                    sqlcon.Open();
                    int rows2 = cmd2.ExecuteNonQuery();

                    sqlcon.Close();
                    if (rows == 1 && rows2 == 1)
                    {
                        MessageBox.Show("Student Admission Information Has Saved", "Data Save Confirmation", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                        this.Close();
                    }
                    else
                        System.Windows.MessageBox.Show("not saved");

            
                    
                    //     +int.Parse(tbid.Text.ToString()) + ",'" + tbname.Text.ToString() + "'," + imageData + ")";
                    /*sqlcon.Open();
                    int rows2 = cmd2.ExecuteNonQuery();

                    sqlcon.Close();
                    if (rows == 1 && rows2 == 1)
                    {
                        MessageBox.Show("Student Admission Information Has Saved", "Data Save Confirmation", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                        this.Close();
                    }
                    else
                        System.Windows.MessageBox.Show("not saved");*/
                    
        }


        


        

    }
}

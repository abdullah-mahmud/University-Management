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

namespace University_Management
{
    /// <summary>
    /// Interaction logic for Communicate.xaml
    /// </summary>
    public partial class Communicate 
    {
        public Communicate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            group_chat grpchat = new group_chat();
            grpchat.Show();
            this.Close();
        }
    }
}

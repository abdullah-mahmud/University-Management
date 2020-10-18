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

namespace University_Management
{
    /// <summary>
    /// Interaction logic for student_subject_reg.xaml
    /// </summary>
    public partial class student_subject_reg
    {
        public int log = 0;
        public student_subject_reg()
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
    }
}

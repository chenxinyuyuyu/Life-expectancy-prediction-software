using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LifeTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userName=txtUserName.Text;
            int userTime;
            if (int.TryParse(txtTime.Text, out userTime))
            {
                // 转换成功，可以使用 userTime
                int userLifespan = userTime * 4 + 2;
                System.Windows.MessageBox.Show("您的寿命大概为：" + userLifespan + "左右两年");
            }
           
        }
    }
}

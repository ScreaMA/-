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
using System.Diagnostics;

namespace WpfApplication3
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
        private static System.Diagnostics.Process p;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            string a, b,c,d;
            a = T0.Text;
            b = P0.Password;
            d = "@rasdial " + "深澜" + " " + a + " " + b;

            p.StartInfo.FileName = "cmd.exe"; 
            p.StartInfo.UseShellExecute = false; 
            p.StartInfo.RedirectStandardInput = true; 
            p.StartInfo.RedirectStandardOutput = true; 
            p.StartInfo.CreateNoWindow = false; 
            p.Start(); 
            p.StandardInput.WriteLine(d);
            p.StandardInput.WriteLine("exit"); //需要有这句，不然程序会挂机
            //string output = p.StandardOutput.ReadToEnd(); 这句可以用来获取执行命令的输出结果
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void T1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
        
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            p.StandardInput.WriteLine("rasphone -a 深澜");
            p.StandardInput.WriteLine("exit"); //需要有这句，不然程序会挂机
            //string output = p.StandardOutput.ReadToEnd(); 这句可以用来获取执行命令的输出结果
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

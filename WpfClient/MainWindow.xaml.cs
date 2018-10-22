using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Principal;
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

namespace WpfClient
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
        NamedPipeClientStream pipeClient =
            new NamedPipeClientStream("localhost", "testpipe", PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.None);
        StreamWriter sw = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sw != null)
            {
                sw.WriteLine(this.msgBox.Text);
            }
            else
            {
                MessageBox.Show("未建立连接，不能发送消息。");
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                pipeClient.Connect(5000);
                sw = new StreamWriter(pipeClient);
                sw.AutoFlush = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接建立失败，请确保服务端程序已经被打开。");
                this.Close();
            }
        }
    }
}

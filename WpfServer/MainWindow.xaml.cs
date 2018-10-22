using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfServer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thread thread = new Thread((ThreadStart)delegate
            {
                pipeServer.BeginWaitForConnection(WaitForConnectionCallback, pipeServer);
            });
            thread.Start();
        }
        NamedPipeServerStream pipeServer =
            new NamedPipeServerStream("testpipe", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

        private void WaitForConnectionCallback(IAsyncResult ar)
        {
            var pipeServer = (NamedPipeServerStream)ar.AsyncState;
            pipeServer.EndWaitForConnection(ar);
            StreamReader sr = new StreamReader(pipeServer);
            while (true)
            {
                if (pipeServer.IsConnected)
                {
                    String item = sr.ReadLine();
                    Dispatcher.Invoke(delegate { testBox1.Text += ("\n"+item); });
                }
                else
                    break;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          

        }

        private void testBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

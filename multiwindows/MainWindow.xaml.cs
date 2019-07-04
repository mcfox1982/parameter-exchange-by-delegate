using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
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

namespace multiwindows
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public PassParamRoutedEventArgs args1 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMain_OnClick(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            newWindow.TextBoxNew.Text = this.TextBoxMain.Text + " from Main Window";
            newWindow.Show();
            newWindow.MessageBack = MethodBack;

        }

        private void MethodBack(string text)
        {
            this.TextBoxMain.Text = text + " from new windows";
        }


    }

    public class PassParamRoutedEventArgs : RoutedEventArgs
    {
        public string TextBack { get; set; }
        
    }
}

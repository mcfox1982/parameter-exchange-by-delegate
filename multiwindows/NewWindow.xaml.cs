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

namespace multiwindows
{
    /// <summary>
    /// NewWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        public MessagePass.DelegateMessageBack MessageBack;

        private void ButtonNew_OnClick(object sender, RoutedEventArgs e)
        {
            string textNewWin = this.TextBoxNew.Text;

            if (MessageBack != null)
            {
                string type = TextBoxNew.Text;
                MessageBack(type);
            }

            this.Close();
        }
    }
}

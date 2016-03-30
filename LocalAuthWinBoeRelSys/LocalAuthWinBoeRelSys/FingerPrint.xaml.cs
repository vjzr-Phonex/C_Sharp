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

namespace LocalAuthWinBoeRelSys
{
    /// <summary>
    /// FingerPrint.xaml 的交互逻辑
    /// </summary>
    public partial class FingerPrint : UserControl
    {
        public FingerPrint()
        {
            InitializeComponent();
        }

        public void SetAuthLevel(string authLevel1,string authLevel2)
        {
            this.Tip.Text = "需要" + authLevel1 + "+" + authLevel2 + "授权";
            this.Tip.FontSize = 14;
        }

        private void inputFingerPrint1(object sender, RoutedEventArgs e)
        {

        }

        private void inputFingerPrint2(object sender, RoutedEventArgs e)
        {

        }
    }
}

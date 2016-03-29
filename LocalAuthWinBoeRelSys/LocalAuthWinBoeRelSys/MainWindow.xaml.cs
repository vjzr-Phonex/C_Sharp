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
using System.Threading;

namespace LocalAuthWinBoeRelSys
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Password passwordWindow = new Password();
        private FingerPrint fingerPrintWindow = new FingerPrint();

        public MainWindow()
        {
            InitializeComponent();
            this.passwordWindow.setAuthLevel("3", "3");
            this.stackPanel.Children.Add(passwordWindow);
        }

        private void SelectPassword(object sender, RoutedEventArgs e)
        {
            this.stackPanel.Children.RemoveAt(0);
            this.passwordWindow.setAuthLevel("3", "3");
            this.stackPanel.Children.Add(passwordWindow);
        }

        private void SelectFingerPrint(object sender, RoutedEventArgs e)
        {
            this.stackPanel.Children.RemoveAt(0);
            this.fingerPrintWindow.setAuthLevel("3", "0");
            this.stackPanel.Children.Add(fingerPrintWindow);
        }

        private void Submit(object sender, RoutedEventArgs e)
        {

        }

        private void Cancle(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public LocalAuthWinBoeRelSys.Password PasswordWindow
        {
            get { return passwordWindow; }
            set { passwordWindow = value; }
        }

        public LocalAuthWinBoeRelSys.FingerPrint FingerPrintWindow
        {
            get { return fingerPrintWindow; }
            set { fingerPrintWindow = value; }
        }
    }
}

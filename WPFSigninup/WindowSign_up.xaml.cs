using System;
using System.Windows;
using System.Windows.Navigation;

namespace WPFSigninup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowSign_up : Window
    {
        public WindowSign_up()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new Uri("WindowSignIn.xaml", UriKind.RelativeOrAbsolute));

            WindowSign_in SignIn = new WindowSign_in();
            SignIn.Show();

            this.Close();
        }
    }
}

using System;
using System.Windows;
using System.Windows.Navigation;

namespace WPFSigninup
{
    /// <summary>
    /// Interaction logic for WindowSignIn.xaml
    /// </summary>
    public partial class WindowSign_in : Window
    {
        public WindowSign_in()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new Uri("WindowSign_up.xaml", UriKind.RelativeOrAbsolute));

            WindowSign_up SignUp = new WindowSign_up();
            SignUp.Show();

            this.Close();
        }
    }
}

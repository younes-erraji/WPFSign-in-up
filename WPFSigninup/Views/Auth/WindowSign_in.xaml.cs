using System;
using System.Windows;
using System.Windows.Navigation;
using System.Text.RegularExpressions;

namespace WPFSigninup.Views.Auth
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
            bool isValid = true;
            if (txtUserame.Text == string.Empty) {
                usernameErrorMessage.Text = "The Username Field Is Required!";
                isValid = false;
            } else if (new Regex("^[a-z0-9]$").IsMatch(txtUserame.Text.ToLower()) == false) {
                usernameErrorMessage.Text = "Please Enter a Valid Username!";
                isValid = false;
            } else {
                usernameErrorMessage.Text = "";
            }

            if (txtPassword.Text == string.Empty) {
                passwordErrorMessage.Text = "The Password Field Is Required!";
                isValid = false;
            } else if (txtPassword.Text.Length < 7) {
                passwordErrorMessage.Text = "The Password Field Must Contains at Least 7 chars!";
                isValid = false;
            } else {
                passwordErrorMessage.Text = "";
            }

            if (isValid) {
                MessageBox.Show("Good");
            } else {
                return;
            }
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            WindowSign_up SignUp = new WindowSign_up();
            SignUp.Show();

            this.Close();
        }
    }
}

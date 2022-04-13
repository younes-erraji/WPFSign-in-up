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

namespace WPFSigninup
{
    /// <summary>
    /// Interaction logic for WindowSettings.xaml
    /// </summary>
    public partial class WindowSettings : Window
    {
        List<Person> persons = new List<Person>();
        public WindowSettings()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            persons.Add(new Person() { firstName = "Younes", lastName = "ERRAJI" });
            persons.Add(new Person("Safae", "ERRAJI"));
            persons.Add(new Person("Mjide", "ERRAJI"));

            comboPeople.ItemsSource = persons;
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string FullName { get { return $"{firstName} {lastName}"; } }

        public Person() { }
        public Person(string fisrtName, string lastName)
        {
            this.firstName = fisrtName;
            this.lastName = lastName;
        }
    }
}

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

namespace Assignment3
{
    public partial class MainWindow : Window
    {
        private Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 35
        };

        public MainWindow()
        {
            InitializeComponent();
            UpdatePerson();
        }

        private void UpdatePerson()
        {
            lblName.Content = person.FullName;
            lblAge.Content = person.Age;
            chkIsAdult.IsChecked = person.IsAdult;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow dlg = new EditWindow();
            dlg.Owner = this;
            dlg.Person = person;

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                person = dlg.Person;
            }

            UpdatePerson();
        }
    }
}
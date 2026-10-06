using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment3
{
    public partial class EditWindow : Window
    {
        private Person person = new Person();

        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtAge.Text = person.Age.ToString();
            }
        }

        public EditWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int age = int.Parse(txtAge.Text);

                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Age = age;

                DialogResult = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Age must be a whole number.", "Invalid Age");
                txtAge.Focus();
                txtAge.SelectAll();
            }
        }
    }
}
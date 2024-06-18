using StoreManagement.Presenters;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StoreManagement.Views.StartViews
{
    public partial class AddNewUserView : UserControl, IAddNewUserView
    {
        private AddNewUserPresenter _presenter;
        public AddNewUserView(Model model)
        {
            InitializeComponent();
            _presenter = new AddNewUserPresenter(this, model);
            textBox_phone.TextChanged += ValidatePhoneNumber;
            textBox_name.TextChanged += ValidateNameSurname;
            textBox_surname.TextChanged += ValidateNameSurname;
            textBox_username.TextChanged += ValidateUsername;

        }
        public string UserName => textBox_name.Text;
        public string Surname => textBox_surname.Text;
        public string Address => textBox_address.Text;
        public string Phone => textBox_phone.Text; 
        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;
        public string Type => "client"; 

        public event EventHandler AddUser;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
                
        private void button_sign_in_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this, EventArgs.Empty);
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }

        private void ValidatePhoneNumber(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_phone.Text, @"^\d{0,9}$"))
            {
                ShowMessage("Phone number can only contain up to 9 digits.");
                textBox_phone.Text = textBox_phone.Text.Substring(0, textBox_phone.Text.Length - 1);
            }
        }
        private void ValidateNameSurname(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z]*$"))
            {
                ShowMessage("Name and Surname can only contain letters.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length - 1);
            }
        }
        private void ValidateUsername(object sender, EventArgs e)
        {
            if (textBox_username.Text.Contains(" "))
            {
                ShowMessage("Username cannot contain spaces.");
                textBox_username.Text = textBox_username.Text.Replace(" ", string.Empty);
                textBox_username.SelectionStart = textBox_username.Text.Length;
            }
        }
    }
}

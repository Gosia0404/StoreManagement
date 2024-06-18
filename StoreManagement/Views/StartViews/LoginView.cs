using StoreManagement.Views.StartViews;
using StoreManagement.Presenters;
using StoreManagement.Models;
using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.Views;

namespace StoreManagement.Views.StartViews
{
    public partial class LoginView : UserControl, ILoginView
    {
        private LoginPresenter _loginPresenter;
        public LoginView(Model model)
        {
            InitializeComponent();
            _loginPresenter = new LoginPresenter(this, model);
        }

        public string Username => textBox_username.Text;
        public string Password => maskedTextBox_password.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToClientView(int? userId)
        {
            List<Clothes> cart = new List<Clothes> { };
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientProductsView(new Model(), userId, cart));
            }
        }
        public void NavigateToWorkerView(int? userId)
        {
            Model model = new Model();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerProductsView(model, userId));
            }
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            _loginPresenter.Login();
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new AddNewUserView(model));
            }
        }
    }
}

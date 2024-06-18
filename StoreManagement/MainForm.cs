using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views;
using StoreManagement.Views.StartViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class MainForm : Form
    {
        private Model _model;

        public MainForm()
        {
            InitializeComponent();
            _model = new Model();
            ShowUserControl(new LoginView(_model));
        }

        public void ShowUserControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(control);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ShowWorkerProductsView()
        {
            var workerProductsView = new WorkerProductsView(_model, this);
            ShowUserControl(workerProductsView);
        }
    }
}

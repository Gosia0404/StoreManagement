using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class WorkerAddProductView : UserControl, IWorkerAddProductView
    {
        private WorkerAddProductPresenter _presenter;
        private ErrorProvider errorProvider;
        public WorkerAddProductView(Model model)
        {
            InitializeComponent();
            _presenter = new WorkerAddProductPresenter(this, model);
            button_save.Click += button_save_Click;
            textBox_price.Validating += textBox_price_Validating;

            errorProvider = new ErrorProvider();
        }
        public string ProductName => textBox_product_name.Text;
        public string Type => comboBox_type.Text;
        public string Colour => comboBox_color.Text;
        public string Price => textBox_price.Text;
        public string ProductSize => comboBox_size.Text;
        public uint Amount => 1;
        
        public event EventHandler SaveProduct;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearForm()
        {
            textBox_product_name.Text = "";
            comboBox_type.Text = "";
            comboBox_color.Text = "";
            textBox_price.Text = "0";
            comboBox_size.Text = "";
        }
        
        private void textBox_price_Validating(object sender, CancelEventArgs e)
        {
            if (!uint.TryParse(textBox_price.Text, out uint price) )
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_price, "Invalid price format or value. Please enter a valid positive number.");
            }
            else
            {
                errorProvider.SetError(textBox_price, ""); // Clear error if validation passes
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                SaveProduct?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

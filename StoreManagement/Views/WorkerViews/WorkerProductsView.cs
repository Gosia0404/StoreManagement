using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.StartViews;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class WorkerProductsView : UserControl, IWorkerProductsView
    {
        private WorkerProductsViewPresenter _presenter;
        private Model _model;
        private Model model;
        private MainForm mainForm;

        public event EventHandler DeleteProduct;
        
        public WorkerProductsView(Model model, int? userId)
        {
            InitializeComponent();
            _model = model;
            _presenter = new WorkerProductsViewPresenter(this, _model, mainForm);
        }

        public WorkerProductsView(Model model, MainForm mainForm)
        {
            this.model = model;
            this.mainForm = mainForm;
        }

        public void DisplayAvailableClothes(List<Clothes> clothes)
        {
            listBox_products.Items.Clear();
            foreach (var item in clothes)
            {
                listBox_products.Items.Add($"{item.Name} ({item.Category}) - Size: {item.Size}, Colour: {item.Colour}, Price: {item.Price}, Amount: {item.Amount}");
            }
        }
        public Clothes GetSelectedClothes()
        {
            if (listBox_products.SelectedItem != null)
            {
                string selectedItem = listBox_products.SelectedItem.ToString();
                string name = selectedItem.Split('(')[0].Trim();
                string category = selectedItem.Split('(')[1].Split(')')[0].Trim();

                foreach (var cloth in _model.Clothes)
                {
                    if (cloth.Name == name && cloth.Category == category)
                    {
                        return cloth;
                    }
                }
            }
            return null;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new WorkerAddProductView(model));
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var selectedClothes = GetSelectedClothes();
            if (selectedClothes != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteProduct?.Invoke(selectedClothes, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
private void button_edit_Click(object sender, EventArgs e)
{
   Model model = new Model();
   MainForm mainForm = this.ParentForm as MainForm;
   if (mainForm != null)
   {
       mainForm.ShowUserControl(new WorkerEditProductView(model));
   }
}
*/
    }
}

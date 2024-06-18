using StoreManagement.DAL.Entities;
using StoreManagement.DAL.Repositories;
using StoreManagement.Presenters;
using StoreManagement.Views.ClientViews;
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
using StoreManagement.Views.StartViews;

namespace StoreManagement.Views
{
    public partial class ClientProductsView : UserControl, IClientProductsView
    {
        private ClientProductsPresenter _clientProductsPresenter;
        private int? _clientId;
        private List<Clothes> _availableClothes;
        private List<Clothes> _cartItems;
        public ClientProductsView(Model model, int? userId, List<Clothes> cartItems)
        {
            InitializeComponent();
            _clientProductsPresenter = new ClientProductsPresenter(this, model);
            _clientId = userId;
            _availableClothes = model.LoadAvailableClothes();
            _cartItems = cartItems;
            DisplayAvailableClothes(_availableClothes);
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void DisplayAvailableClothes(List<Clothes> clothes)
        {
            listBox_client_product.Items.Clear();
            foreach (var item in clothes)
            {
                listBox_client_product.Items.Add(item.Name);
            }
        }
        public List<Clothes> GetSelectedClothes()
        {
            var selectedClothes = new List<Clothes>();
            foreach (var selectedItem in listBox_client_product.SelectedItems)
            {
                var selectedCloth = _availableClothes.First(c => c.Name == selectedItem.ToString());
                selectedClothes.Add(selectedCloth);
            }
            return selectedClothes;
        }
        public void button_cart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientCartView(_clientProductsPresenter.Model, _clientId, _cartItems));
            }
        }
        public void button_my_orders_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new ClientOrdersView(_clientProductsPresenter.Model, _clientId));
            }
        }
        public void button_logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowUserControl(new LoginView(new Model()));
            }
        }

        private void button_add_cart_Click(object sender, EventArgs e)
        {
            var selectedClothes = GetSelectedClothes();
            foreach (var cloth in selectedClothes)
            {
                _cartItems.Add(cloth);
            }
            ShowMessage("Selected items added to cart");
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox_type.SelectedItem?.ToString();
            string selectedColor = comboBox_color.SelectedItem?.ToString();
            string selectedSize = comboBox_size.SelectedItem?.ToString();
            //uint.TryParse(comboBox_price.SelectedItem?.ToString(), out uint selectedPrice);

            var filteredClothes = _availableClothes
                .Where(c => (string.IsNullOrEmpty(selectedType) || c.Category == selectedType) &&
                            (string.IsNullOrEmpty(selectedColor) || c.Colour == selectedColor) &&
                            (string.IsNullOrEmpty(selectedSize) || c.Size == selectedSize) /*&&
                            (selectedPrice == 0 || c.Price <= selectedPrice)*/)
                .ToList();

            listBox_client_product.Items.Clear();
            foreach (var clothes in filteredClothes)
            {
                listBox_client_product.Items.Add(clothes.Name);
            }
        }
    }
}

using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Presenters;
using StoreManagement.Views.ClientViews;
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
    public partial class ClientCartView : UserControl, IClientCartView
    {
        private ClientCartPresenter _presenter;
        private int? _clientId;
        private List<Clothes> _cartItems;
        public ClientCartView(Model model, int? clientId, List<Clothes> cartItems)
        {
            InitializeComponent();
            _presenter = new ClientCartPresenter(this, model, clientId, cartItems);
            _clientId = clientId;
            _cartItems = cartItems;
            LoadCartItems();
        }

        public void DisplayCartItems(List<Clothes> cartItems)
        {
            listBox_cart.Items.Clear();
            foreach (var item in cartItems)
            {
                listBox_cart.Items.Add($"{item.Name} - {item.Price}");
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_cart.SelectedIndex != -1)
            {
                var selectedIdx = listBox_cart.SelectedIndex;
                var removedItem = _cartItems[selectedIdx];
                _presenter.RemoveFromCart(removedItem);
                _cartItems.Remove(removedItem); // Update local cart items list
                LoadCartItems();
            }
            else
            {
                ShowMessage("Please select an item to remove.");
            }
        }
        private void button_purchase_Click(object sender, EventArgs e)
        {
            _presenter.PurchaseItems();
        }
        private void LoadCartItems()
        {
            DisplayCartItems(_cartItems);
        }
    }
}

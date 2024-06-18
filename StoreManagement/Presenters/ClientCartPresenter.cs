using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;
using System.Windows.Forms;

namespace StoreManagement.Presenters
{
    public class ClientCartPresenter
    {
        private IClientCartView _view;
        private Model _model;
        private readonly int? _clientId;
        private List<Clothes> _cartItems;

        public ClientCartPresenter(IClientCartView view, Model model, int? clientId, List<Clothes> cartItems)
        {
            _view = view;
            _model = model;
            _clientId = clientId;
            _cartItems = cartItems;
            LoadCartItems();
        }
        
        public void LoadCartItems()
        {
            _view.DisplayCartItems(_cartItems);
        }
        public void RemoveFromCart(Clothes clothes)
        {
            _model.RemoveFromCart(clothes);
            clothes.Amount++;
            _model.UpdateClothes(clothes);
            LoadCartItems();
        }

        public void PurchaseItems()
        {
            // do dokończenia
            _model.ClearCart();
            _view.ShowMessage("Purchase completed successfully!");
            LoadCartItems();
        }
        /*public List<Clothes> GetCartItems()
        {
            return _model.GetCartItems();
        }*/
    }
}

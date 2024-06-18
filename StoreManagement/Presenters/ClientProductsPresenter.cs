using StoreManagement.Views.ClientViews;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presenters
{
    public class ClientProductsPresenter
    {
        private IClientProductsView _clientProductsView;
        private Model _model;
        public ClientProductsPresenter(IClientProductsView clientProductsView, Model model)
        {
            _clientProductsView = clientProductsView;
            _model = model;
            LoadAvailableClothes();
        }
        public Model Model
        {
            get { return _model; }
        }
        public void LoadAvailableClothes()
        {
            var clothes = _model.LoadAvailableClothes();
            _clientProductsView.DisplayAvailableClothes(clothes);
        }

        public void AddToCart()
        {
            var selectedClothes = _clientProductsView.GetSelectedClothes();
            foreach (var clothes in selectedClothes)
            {
                if (clothes.Amount > 0)
                {
                    clothes.Amount--;
                    _model.UpdateClothes(clothes);
                    _model.AddToCart(clothes);
                    _clientProductsView.ShowMessage($"{clothes.Name} added to cart");
                }
                else
                {
                    _clientProductsView.ShowMessage("This item is out of stock.");
                }
            }
            LoadAvailableClothes();
        }
    }
}

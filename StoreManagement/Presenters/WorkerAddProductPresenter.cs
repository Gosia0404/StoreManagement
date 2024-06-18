using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class WorkerAddProductPresenter
    {
        private readonly IWorkerAddProductView _view;
        private readonly Model _model;
        public WorkerAddProductPresenter(IWorkerAddProductView view, Model model)
        {
            _view = view;
            _model = model;

            _view.SaveProduct += SaveProductHandler;
        }

        private void SaveProductHandler(object sender, EventArgs e)
        {
            string productName = _view.ProductName;
            string type = _view.Type;
            string colour = _view.Colour;
            string priceText = _view.Price;
            string size = _view.ProductSize;
            uint amount = 1;

            if (!uint.TryParse(priceText, out uint price) )
            {
                _view.ShowMessage("Invalid price format or value. Please enter a valid positive number.");
                return;
            }

            // Przygotowanie do zapisu produktu do bazy danych
            Clothes newClothes = new Clothes
            {
                Name = productName,
                Category = type,
                Colour = colour,
                Price = price,
                Size = size,
                Amount = amount
            };

            try
            {
                if (_model.AddProductToDB(newClothes))
                {
                    _view.ClearForm();
                    _view.ShowMessage("Product added successfully.");
                }
                else
                {
                    _view.ShowMessage("Error adding product.");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error: {ex.Message}");
            }
        }

        }
}

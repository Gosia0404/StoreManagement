using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    internal class WorkerProductsViewPresenter
    {
        private IWorkerProductsView _view;
        private Model _model;
        private MainForm _mainForm;

        public WorkerProductsViewPresenter(IWorkerProductsView view, Model model, MainForm mainForm)
        {
            _view = view;
            _model = model;
            _mainForm = mainForm;
            LoadAvailableClothes();
            _view.DeleteProduct += DeleteProductHandler;
        }
        private void LoadAvailableClothes()
        {
            List<Clothes> availableClothes = _model.LoadAvailableClothes();
            _view.DisplayAvailableClothes(availableClothes);
        }
        private void DeleteProductHandler(object sender, EventArgs e)
        {
            var selectedClothes = sender as Clothes;
            if (selectedClothes != null)
            {
                try
                {
                    if (_model.DeleteClothesFromDB(selectedClothes))
                    {
                        _view.ShowMessage("Product deleted successfully.");
                        // Odśwież listę produktów po usunięciu
                        var clothesList = _model.LoadAvailableClothes();
                        _view.DisplayAvailableClothes(clothesList);
                    }
                    else
                    {
                        _view.ShowMessage("Error deleting product.");
                    }
                }
                catch (Exception ex)
                {
                    _view.ShowMessage($"Error: {ex.Message}");
                }
            }
        }
            /*
            private void AddProduct(object sender, EventArgs e)
            {
                // Navigate to WorkerAddProductView with the Model instance
                _mainForm.ShowUserControl(new WorkerAddProductView(_model));
            }
            */
            /*
            private void EditProduct(object sender, EventArgs e)
            {
                var selectedClothes = _view.GetSelectedClothes();
                if (selectedClothes != null)
                {
                    MainForm mainForm = (MainForm)_view;
                    mainForm.ShowUserControl(new WorkerEditProductView(selectedClothes));
                }
                else
                {
                    _view.ShowMessage("Select a product to edit.");
                }
            }
            */
        }
}

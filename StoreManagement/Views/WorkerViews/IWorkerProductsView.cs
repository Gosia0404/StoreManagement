using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerProductsView
    {
        void DisplayAvailableClothes(List<Clothes> clothes);
        Clothes GetSelectedClothes();
        void ShowMessage(string message);
        event EventHandler DeleteProduct;
        
    }
}

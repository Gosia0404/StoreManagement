using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.ClientViews
{
    public interface IClientProductsView
    {
        void DisplayAvailableClothes(List<Clothes> clothes);
        List<Clothes> GetSelectedClothes();
        void ShowMessage(string message);
    }
}

using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.ClientViews
{
    public interface IClientCartView
    {
        void DisplayCartItems(List<Clothes> cartItems);
        void ShowMessage(string message);
    }
}

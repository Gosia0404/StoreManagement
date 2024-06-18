using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerAddProductView
    {
        string ProductName { get; }
        string Type { get; }  
        string Colour { get; }
        string Price { get; }  
        string ProductSize { get; }
        uint Amount { get; }


        event EventHandler SaveProduct;  // Zdarzenie wywoływane przy próbie zapisu produktu
        void ShowMessage(string message);

        void ClearForm();
    }
}

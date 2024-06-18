using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.StartViews
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void ShowMessage(string message);
        void NavigateToClientView(int? userId);
        void NavigateToWorkerView(int? userId);
    }
}

using StoreManagement.DAL.Entities;
using StoreManagement.Models;
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
    public partial class ClientOrdersView : UserControl, IClientOrdersView
    {

        public ClientOrdersView(Model model, int? clientId)
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdmin
{
    public partial class frmOrders : Form
    {
        private List<clsOrder> Orders;
        public frmOrders()
        {
            InitializeComponent();
            getorderslist();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void getorderslist()
        {
            lstOrders.DataSource = null;
            Orders = await ServiceClient.GetOrdersAsync();
            lstOrders.DataSource = Orders;
        }
    }
}

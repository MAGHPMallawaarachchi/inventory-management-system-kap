using InventoryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system_kap.Views
{
    public partial class InvoicesView : Form
    {
        UIHelper UIHelper = new UIHelper();
        public InvoicesView()
        {
            InitializeComponent();
        }

        private void InvoicesView_Load(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(pnlInvoices);
        }

        private void pnlInvoices_SizeChanged(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(pnlInvoices);
        }
    }
}

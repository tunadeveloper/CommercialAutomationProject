using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Products productsForm;
		private void products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
            if(productsForm == null) {
            productsForm = new Products();
            productsForm.MdiParent = this;
            productsForm.Show();
		}
		}
	}
}

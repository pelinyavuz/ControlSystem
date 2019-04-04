using NursanDataLayer;
using NursanModel.Model;
using NursanWinFormUI.Views.Copper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NursanWinFormUI
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NursanDbContext _db = new NursanDbContext();

            Suppliers suppliers = new Suppliers();
            suppliers.Id = 1;
            suppliers.SuppliersName = "Şirket";
            suppliers.ProductType = "Bakır";
            _db.Suppliers.Add(suppliers);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CopperStandartForm bform = new CopperStandartForm();
            bform.MdiParent = this;
            bform.Show();
            bform.Activate();
           
        }
    }
}

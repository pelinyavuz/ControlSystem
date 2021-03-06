﻿using DevExpress.XtraEditors;
using NursanDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NursanWinFormUI.Views.Copper
{
    public partial class CopperStandartForm : Form
    {
        NursanDbContext dbContext = new NursanDbContext();
        public CopperStandartForm()
        {
            InitializeComponent();
            dbContext.CopperStandarts.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.CopperStandarts.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            NursanDataLayer.NursanDbContext dbContext = new NursanDataLayer.NursanDbContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Suppliers.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Suppliers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void CopperStandartForm_Load(object sender, EventArgs e)
        {


            
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }

        
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {
                gridControl1.DeleteRow(gridControl1.FocusedRowHandle);
                dbContext.SaveChanges();
                //copperStandartsTableAdapter.Update(nURSANKABLODataSet.CopperStandarts);
                e.Handled = true;
            }
        }

        private void unitOfWork1_SchemaInit(object sender, DevExpress.Xpo.SchemaInitEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform.ChildForms;
using Winform.Diaglog;
using Winform.Dialog;

namespace Winform
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public static frmMain frmMainInstance ;
        public event Action ReloadRequested; // Action để reload dữ liệu cho form

        // Phương thức này sẽ được gọi ở các form con, khi các form con có thay đổi db sẽ gọi để load lại toàn bộ form
        // tất cả phương thức reload đều được gọi
        public void RequestReload() 
        {
            ReloadRequested?.Invoke();
        }

        public void ClearReloadRequestedEvent()
        {
            ReloadRequested = null;
        }


        public frmMain()
        {

            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            if (lg.DialogResult != DialogResult.OK)
            {
                Environment.Exit(0);
            }

            InitializeComponent();
            frmMainInstance = this;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
         
        }
        private void addContent(Control form)
        {
            pnContent.Controls.Clear();
            form.Dock = DockStyle.Fill;
            pnContent.Controls.Add(form);
        }



        private void managerProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearReloadRequestedEvent(); // clear event before call new child form
            frmProducts f = new frmProducts();
            addContent(f);
        }

        private void managerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearReloadRequestedEvent();// clear event before call new child form
            frmCustomer f = new frmCustomer();
            addContent(f);
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearReloadRequestedEvent();// clear event before call new child form
            frmOrders f = new frmOrders();
            addContent(f);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearReloadRequestedEvent();// clear event before call new child form
            dialog_Popup f = new dialog_Popup(); // defaut add and items
            f.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearReloadRequestedEvent();// clear event before call new child form
            dialog_Popup f = new dialog_Popup(1, 2); // action add, type customer
            f.Show();
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearReloadRequestedEvent();// clear event before call new child form
            dialog_Order f = new dialog_Order();
            f.Show();
        }



        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearReloadRequestedEvent();// clear event before call new child form
            frmReport f = new frmReport();
            addContent(f);
        }
    }
}

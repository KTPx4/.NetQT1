using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Dialog;

namespace Winform.ChildForms
{
    public partial class frmOrders : UserControl
    {
        public frmOrders()
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

        }
        void Reload()
        {
            // xử lý reload lại dabase vào các field chứa dữ liệu

            loadOrders();
        }
        void loadOrders()
        {
            try
            {
                //MessageBox.Show("Load 1 time");
                orderBindingSource.DataSource = null;
                Connections.Connection cn = new Connections.Connection();
                QT1Entities db = new QT1Entities(cn.GetConnectionString());
                orderBindingSource.DataSource = db.Orders.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            dialog_Order od = new dialog_Order();   
            od.Show();
        }

  
    }
}

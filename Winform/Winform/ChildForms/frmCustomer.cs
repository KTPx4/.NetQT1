using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Diaglog;
using Winform.Dialog;

namespace Winform.ChildForms
{
    public partial class frmCustomer : UserControl
    {
        public frmCustomer()
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

        }
        void Reload()
        {
            // xử lý reload lại dabase vào các field chứa dữ liệu

            loadGridviews();
        }
        void loadGridviews()
        {
            try
            {
                Connections.Connection cn = new Connections.Connection();
                QT1Entities db = new QT1Entities(cn.GetConnectionString());
                customerBindingSource.DataSource = db.Customers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadGridviews();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dialog_Popup f = new dialog_Popup(1, 2);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dialog_Popup f = new dialog_Popup(2, 2);
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
     
    }
}

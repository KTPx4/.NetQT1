using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Diaglog;
using Winform.Dialog;
using Winform.Model;

namespace Winform.ChildForms
{
    public partial class frmCustomer : UserControl
    {
        private CT_Customer DataCustomer;
        public frmCustomer()
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 
            DataCustomer = new CT_Customer();

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
                customerBindingSource.DataSource = DataCustomer.GetAllCustomers(); // load data
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
            // MessageBox.Show(DataCustomer.getMaxID());
            // DataCustomer.AddCustomer("11111", "aaaa", "dsadsad");
            //DataCustomer.EditCustomer("10", "px4k3", "jkl");
            frmMain.frmMainInstance.RequestReload();
        }
     
    }
}

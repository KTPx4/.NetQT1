using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Model;

namespace Winform.Dialog
{
    public partial class box_customer : UserControl
    {
        private Action<Control> deleteItem;
        private bool isEdit = false;
        public box_customer()
        {
            InitializeComponent();
        }
        public box_customer(Action<Control> delete)
        {
            InitializeComponent(); 
            this.deleteItem = delete;
            lbCountItem.Hide();
        }
        public box_customer(Action<Control> delete, bool isEdit)
        {
            InitializeComponent();
            this.deleteItem = delete;
            this.isEdit = isEdit;
            lbCountItem.Hide();
        }
        public box_customer(Action<Control> deleteItem, int index)
        {
            InitializeComponent();
            this.deleteItem = deleteItem;
            lbCountItem.Show();
            lbCountItem.Text = $"Customer {index}";
        }
        public bool isGetValues()
        {
            if (txtID.Text == "") return false;
            else if (txtName.Text == "") return false;
            else if (txtAddress.Text == "") return false;
        
            return true;

        }
        public List<String> getItem()
        {
            List<String> list = new List<String>()
            {
                txtID.Text,
                txtName.Text,
                txtAddress.Text 
            };

            return list;

        }
        private void box_customer_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                //Customer cs = new MDCustomer().getFID("521H0125");
                
                //IQueryable<Customer> li = new MDCustomer().getFromID("521H0125");           
                //foreach (Customer customer in li)
                //{
                //    string id = customer.CustID; // Lấy ID
                //    string name = customer.CustName; // Lấy tên
                //    string address = customer.Address; // Lấy địa chỉ

                //    // Sử dụng thông tin tại đây (ví dụ: hiển thị trong ComboBox)
                //    cbbT.Items.Add($"{id} - {name} ({address})");
                //}

                btnDel.Enabled = false;
                btnDel.BackColor = Color.Gray;
                txtID.Enabled = false;
            }
            else
            {
                btnDel.Enabled = true;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteItem(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
           
        }

        public void setTitle(int index)
        {
            lbCountItem.Text = "Customer " + index.ToString();
        }
    }
}

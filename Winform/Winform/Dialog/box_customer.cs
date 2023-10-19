using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void box_customer_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
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

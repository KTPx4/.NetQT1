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
    public partial class box_Item : UserControl
    {


        private Action<Control> deleteItem;

        private bool isEdit = false;
        public box_Item()
        {
            InitializeComponent();
            lbCountItem.Hide();
           
        }
        public box_Item(Action<Control> deleteItem)
        {
            InitializeComponent();
            this.deleteItem = deleteItem;
            lbCountItem.Hide(); 
          
        }
        public box_Item(Action<Control> deleteItem, bool isEdit)
        {
            InitializeComponent();
            this.deleteItem = deleteItem;
            this.isEdit = isEdit;
            lbCountItem.Hide();
          
        }
        public box_Item(Action<Control> deleteItem, int index)
        {
            InitializeComponent();
            this.deleteItem = deleteItem;
            lbCountItem.Show();
            lbCountItem.Text = $"Item {index}";
           
        }
        public bool isGetValues()
        {
            if (txtID.Text == "") return false;
            else if (txtName.Text == "") return false;
            else if(txtSize.Text == "") return false;
            else if(!double.TryParse(txtPrice.Text, out double b)) return false;
            return true;

        }
        public  List<String> getItem()
        {
            List<String> list = new List<String>()
            {
                txtID.Text,
                txtName.Text,
                txtSize.Text ,
                txtPrice.Text 
            };
          
            return list;

        }

        private void box_Item_Load(object sender, EventArgs e)
        {
            if(isEdit)
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
            txtSize.Text = "";
            txtPrice.Text = "";
        }

        public void setTitle(int index)
        {
            lbCountItem.Text = "Item "+ index.ToString();
        }



    }
}

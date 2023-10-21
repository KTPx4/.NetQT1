using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Winform.Controller;

namespace Winform.Dialog
{
    public partial class box_Items_Order : UserControl
    {
        private Action<Control> deleteThis;

        public box_Items_Order()
        {
            InitializeComponent();
    
        }
     
        public box_Items_Order(Action<Control> del)
        {
            InitializeComponent();
            deleteThis = del;


        }
        public bool isGetValues()
        {
            if(cbbIID.Text == "")
                return false;
            else if(txtQuan.Text == "" || !int.TryParse(txtQuan.Text, out int value))
                return false;

            return true;

        }
        public List<String> getItem()
        {
            List<String> list = new List<String>()
            {
                cbbIID.Text,
                txtQuan.Text,
                txtSum.Text
            };

            return list;

        }
        private void ptbDel_Click(object sender, EventArgs e)
        {
            deleteThis(this);
        }

        private void box_Items_Order_Load(object sender, EventArgs e)
        {
            List<Item> li = new CT_Product().GetAll();
            foreach(Item i in li)
            {
                String id = i.ItemID.ToString();
                String name = i.ItemName.ToString();
                cbbIID.Items.Add(id);
            }
        }
        public void setTitle(int index)
        {
            lbCount.Text = "Item " + index.ToString();
        }

        private void ptbDel_MouseHover(object sender, EventArgs e)
        {
            ptbDel.BackColor = Color.Gray;
        }

        private void ptbDel_MouseLeave(object sender, EventArgs e)
        {
            ptbDel.BackColor = Color.Transparent;
        }

        private void cbbIID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbIID.Text != "")
            {
                string id = cbbIID.Text;
                IQueryable<Item> li = new CT_Product().getFromID(id);
                foreach(Item i in li)
                {
                    string name = i.ItemName.ToString();
                    cbbName.Text = name;
                }
            }
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txtQuan.Text, out int n))
            {
                txtQuan.Text = "";
            }
            string id = cbbIID.Text;
            IQueryable<Item> li = new CT_Product().getFromID(id);
            foreach (Item i in li)
            {
                decimal? price = i.Price;
                txtSum.Text =( price * (decimal) int.Parse(txtQuan.Text)).ToString();
                //cbbName.Text = name;
            }
        }
    }
}

using DevExpress.XtraBars.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Controller;
using Winform.Model;

namespace Winform.Dialog
{
    public partial class dialog_Order : Form
    {
        public Action<Control> DeleteItem;
        public Action<int> UpdateTitle;
        private List<Control> ListItem = new List<Control>();
        public dialog_Order()
        {
            InitializeComponent();
            DeleteItem = deleteItem;
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

        }

        void Reload()
        {
            // xử lý reload lại dabase vào các field chứa dữ liệu
       //     MessageBox.Show("Dialog order load 1time");
          
        }

        void updateCount()
        {
            int i = 1; int sumquan = 0;
            decimal sumpr = 0;
            foreach (box_Items_Order c in ListItem)
            {
               c.setTitle(i++);
                if (!c.isGetValues())
                {
                  //  MessageBox.Show($"The values invalid at Item {i++}", "Error input", MessageBoxButtons.OK);
                }
                else
                {
                    List<string> values = c.getItem();                 

                 
                    int quan = int.Parse(values[1]);
                    sumquan += quan;

                    decimal unit = decimal.Parse(values[2]);
                    sumpr += unit;
                   
                

                }
            }
            txtSumItem.Text = sumquan.ToString();
            txtSumPrice.Text = sumpr.ToString();
        }
        void deleteItem(Control item)
        {
            ListItem.Remove(item);
            pnContent.Controls.Remove(item);
            updateCount();
        }
        void addItem()
        {
            box_Items_Order f = new box_Items_Order(DeleteItem);
            f.Dock = DockStyle.Top;
            pnContent.Controls.Add(f);
            ListItem.Add(f);
            updateCount();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addItem();
           
        }

        private void dialog_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.frmMainInstance.ReloadRequested -= Reload; // xóa sự kiện reload khi đóng form
        }
        void createOrder()
        {
            if (txtOD.Text == "")
            {
                MessageBox.Show("Order ID null values");
                return;
            }
            else if(cbbCustID.Text == "")
            {
                MessageBox.Show("Please chose Customer!");
                return;
            }
            else if(dateO.Text == "")
            {
                MessageBox.Show("Please chose Date!");
                return;
            }
            CT_Order controller = new CT_Order();
            controller.Add(txtOD.Text, dateO.DateTime, cbbCustID.Text);

            int i = 0;
            int index = 0;
            int sumquan = 0;
            decimal sumpr = 0;
            foreach (box_Items_Order item in ListItem)
            {
                
                if (!item.isGetValues())
                {
                    MessageBox.Show($"The values invalid at Item {i++}", "Error input", MessageBoxButtons.OK);
                }
                else
                {
                    List<string> values = item.getItem();
                    CT_ODetail oDetail = new CT_ODetail();
                    string Iid = values[0];
                    int quan = int.Parse(values[1]);
                    sumquan += quan;
                    decimal unit = decimal.Parse(values[2]);                
                    sumpr += unit;
                    string id = txtOD.Text + index.ToString() + Iid;
                    oDetail.Add(id,txtOD.Text, Iid, quan, unit);               

                }
            }
         
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ListItem.Count < 1)
            {
                MessageBox.Show("Null Item");
                return;
            }
            createOrder();
                
            this.DialogResult = DialogResult.OK;
            // action to db


            //reload
            frmMain.frmMainInstance.RequestReload();
            this.Close();
        }

        private void dialog_Order_Load(object sender, EventArgs e)
        {
            List<Customer> li = new CT_Customer().GetAllCustomers();
            foreach (Customer i in li)
            {
                String id = i.CustID.ToString();
                
                cbbCustID.Items.Add(id);
            }
        }

        private void cbbCustID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCustID.Text != "")
            {
                string id = cbbCustID.Text;
                IQueryable<Customer> li = new CT_Customer().getFromID(id);
                foreach (Customer i in li)
                {
                    string name = i.CustName.ToString();
                    cbbCustName.Text = name;
                }
            }
        }
    }
}

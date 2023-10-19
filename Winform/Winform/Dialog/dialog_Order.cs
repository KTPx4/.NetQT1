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
            int i = 1;
            foreach (box_Items_Order c in ListItem)
            {
               c.setTitle(i++);
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // action to db


            //reload
            frmMain.frmMainInstance.RequestReload();
            this.Close();
        }
    }
}

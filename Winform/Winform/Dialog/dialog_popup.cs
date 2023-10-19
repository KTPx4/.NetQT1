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

namespace Winform.Diaglog
{

    public partial class dialog_Popup : Form
    {
        private int typeAction;
        // typeActon = 1 -> add 1 or more items
        // typeActon = 2 -> edit 1 item

        private int typePopup;
        // typePopup when call dialog,
        //typePopup = 1 -> item,
        //typePopup = 2 -> customer

        public Action<Control> deleteItem;
        private List<Control> listItems = new List<Control>();
        private int index = 1;
        

        // constructor
        public dialog_Popup()
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

            typeAction = 1;
            typePopup = 1;
            deleteItem = deleteBox;
        }
        public dialog_Popup(int typeAction)
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

            this.typeAction = typeAction;
            typePopup = 1;
            deleteItem = deleteBox;

        }
        public dialog_Popup(int typeAction, int typePopup)
        {
            InitializeComponent();
            frmMain.frmMainInstance.ReloadRequested += Reload; // Đăng ký sự kiện reload vào delegate chung của main, để khi một form nào đó gọi reload sẽ load toàn bộ 

            this.typeAction = typeAction;
            deleteItem = deleteBox;
            this.typePopup = typePopup;

        }


        void Reload()
        {
            // xử lý reload lại dabase vào các field chứa dữ liệu


        }

        //load form
        private void dialog_editItems_Load(object sender, EventArgs e)
        {
            switch (typePopup)
            {
                case 1:
                    itemLoad();
                    break;

                case 2:
                    customerLoad();
                    break;

                case 3:

                    break;
            }

        }
        void updateCount()
        {
            int i = 1;
            if(typePopup == 1)
            {
                foreach (box_Item item in listItems)
                {
                    item.setTitle(i++);
                }
            }
            else if(typePopup==2)
            {
                foreach (box_customer item in listItems)
                {
                    item.setTitle(i++);
                }
            }
            
           
        }

        private void deleteBox(Control item) // remove from panel content
        {
            listItems.Remove(item);
            pnContent.Controls.Remove(item);
            updateCount();
        }

        private void addBox(Control item) // add to content
        {
            item.Dock = DockStyle.Top;
            listItems.Add(item);
            pnContent.Controls.Add(item);
            updateCount();
        }



        private void itemLoad()
        {
            this.Text = "Manager Items";
            switch (typeAction) // type of dialog item, 1 for add, 2 for edit
            {

                case 1:
                    btnAdd.Show();
                    box_Item item = new box_Item(deleteItem, index);
                    addBox(item);
                    break;

                case 2:
                    btnAdd.Hide();
                    box_Item itemEdit = new box_Item(deleteItem, true);
                    addBox(itemEdit);
                    break;

            }
        }
        
        private void customerLoad()
        {
            this.Text = "Manager Customers";
            switch (typeAction) // type of dialog customer, 1 for add, 2 for edit
            {

                case 1:
                    btnAdd.Show();
                    box_customer item = new box_customer(deleteItem, index);
                    addBox(item);
                    break;

                case 2:
                    btnAdd.Hide();
                    box_customer itemEdit = new box_customer(deleteItem, true);
                    addBox(itemEdit);
                    break;

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            index++;
            switch (typePopup)
            { 
                
                case 1:
                   
                    box_Item item = new box_Item(deleteItem, index);
                    addBox(item);
                    break;

                case 2:
                    box_customer customer = new box_customer(deleteItem, index);
                    addBox(customer);
                    break;

                case 3:

                    break;
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            frmMain.frmMainInstance.RequestReload();
            this.Close();
        }

        private void dialog_Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.frmMainInstance.ReloadRequested -= Reload; // xóa sự kiện reload khi đóng form

        }
    }
}

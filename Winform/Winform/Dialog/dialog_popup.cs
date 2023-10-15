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

    public partial class dialog_editItems : Form
    {
        private int type;
        private int typePopup;
        public Action<Control> deleteItem;
        private List<Control> listItems = new List<Control>();
        private int index = 1;
        // type = 1 -> add 1 or more items
        // type = 2 -> edit 1 item

        public dialog_editItems()
        {
            InitializeComponent();
            type = 1;
            typePopup = 1;
            deleteItem = delete;
        }

        public dialog_editItems(int type)
        {
            InitializeComponent();
            this.type = type;
            typePopup = 1;
            deleteItem = delete;

        }
        public dialog_editItems(int type, int typePopup)
        {
            InitializeComponent();
            this.type = type;
            deleteItem = delete;
            this.typePopup = typePopup;

        }
        private void dialog_editItems_Load(object sender, EventArgs e)
        {
            switch (typePopup)
            {
                case 1:
                    itemLoad();
                    break;

                case 2:

                    break;

                case 3:

                    break;
            }

        }

        private void itemLoad()
        {
            switch (type)
            {

                case 1:
                    btnAdd.Show();
                    box_Item item = new box_Item(deleteItem, index);
                    openItem(item);
                    break;

                case 2:
                    btnAdd.Hide();
                    box_Item itemEdit = new box_Item(deleteItem, true);
                    openItem(itemEdit);
                    break;

            }
        }
        private void delete(Control item)
        {
            listItems.Remove(item);
            pnContent.Controls.Remove(item);

        }

        private void openItem(Control item)
        {
            listItems.Add(item);
            item.Dock = DockStyle.Top;
            pnContent.Controls.Add(item);
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (typePopup)
            {
                case 1:
                    index++;
                    box_Item item = new box_Item(deleteItem, index);
                    openItem(item);
                    break;

                case 2:

                    break;

                case 3:

                    break;
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

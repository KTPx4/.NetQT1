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

        private void ptbDel_Click(object sender, EventArgs e)
        {
            deleteThis(this);
        }

        private void box_Items_Order_Load(object sender, EventArgs e)
        {

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
    }
}

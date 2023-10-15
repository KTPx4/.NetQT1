using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Diaglog;

namespace Winform.ChildForms
{
    public partial class frmProducts : UserControl
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                Connections.Connection cn = new Connections.Connection();
                QT1Entities db = new QT1Entities(cn.GetConnectionString());
                itemBindingSource.DataSource = db.Items.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dialog_editItems f = new dialog_editItems();
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dialog_editItems f = new dialog_editItems(2);
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

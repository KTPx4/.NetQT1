using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform.ChildForms;

namespace Winform
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            /*
                frmLogin lg = new frmLogin();
                lg.ShowDialog();
                if(lg.DialogResult != DialogResult.OK)
                {
                    Environment.Exit(0);
                } 
            */
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
         
        }
        private void addContent(Control form)
        {
            pnContent.Controls.Clear();
            form.Dock = DockStyle.Fill;
           // form.TopLevel = false;
            pnContent.Controls.Add(form);
        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts f = new frmProducts();
            addContent(f);
        }
    }
}

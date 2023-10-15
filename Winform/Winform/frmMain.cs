using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            try
            {
                Connections.Connection cn = new Connections.Connection();
                QT1Entities db = new QT1Entities(cn.GetConnectionString());
                itemBindingSource.DataSource = db.Items.ToList();
            }
            catch (Exception ex)
            {

            }
         
        }
    }
}

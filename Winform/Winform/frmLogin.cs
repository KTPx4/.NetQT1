using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please input full values");
            }
            if(txtUser.Text == "admin" && txtPass.Text == "12345") 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
                
        }
    }
}

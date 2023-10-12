using DevExpress.XtraEditors;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool checkInput()
        {
            if(txtUser.Text == "" || txtPass.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!checkInput())
            {
                MessageBox.Show("User or Pass must have values", "Error input", MessageBoxButtons.OK);
                return;
            }
            if(!checkAccount(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("User or Pass not correct", "Login Failed", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Welcom to the application", "Login Success", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
        }


        bool checkAccount(string user, string pass)
        {
            if(user == "a" && pass == "b") return true;
            return false;
        }
    }
}
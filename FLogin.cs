using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Informe o usúario";
                txtUser.ForeColor = Color.Gray;
            }
                
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";

        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text == "")
            {
                txtSenha.Text = "Informe a senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }
    }
}


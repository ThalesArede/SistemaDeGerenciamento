using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class frmMenuPrincipal : Form
    {
        private FormManager _formManager;

        public frmMenuPrincipal(FormManager formManager)
        {
            InitializeComponent();
            _formManager = formManager;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            _formManager.AbrirFormNoPanel(new frmServicos());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            _formManager.AbrirFormNoPanel(new frmConfiguracoes());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

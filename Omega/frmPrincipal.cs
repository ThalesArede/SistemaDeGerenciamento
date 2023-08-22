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
    public partial class frmPrincipal : Form
    {

        private FormManager _formManager;

        public frmPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
            _formManager = new FormManager(painelPrincipal);

            MostrarMenuPrincipal();
        }

        private void MostrarMenuPrincipal()
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(_formManager);
            _formManager.AbrirFormNoPanel(menuPrincipal);
        }

        private bool isDragging = false;
        private Point startPoint;
        private void AreaDeArrasto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }
        private void AreaDeArrasto_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }
        private void AreaDeArrasto_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        //Minizar tela
        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isMaximized = false;

        //Maximizar tela
        private void maximizarIcon_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        //Encerrar aplicação
        private void fecharIcone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arrastarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }
    }
}

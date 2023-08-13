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
    public partial class frmAjuda : Form
    {

        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;

        public frmAjuda()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SairIcone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharIcone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximiza a tela clicando no icone
        private void maximizarIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Icone minimzar a tela
        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Função para arrastar a tela
        private void arrastarIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void arrastarIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursorPos.X;
                int deltaY = Cursor.Position.Y - lastCursorPos.Y;
                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

        private void arrastarIcon_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        //Abre o form PaginaInicial novamente e fecha o ajuda
        private void paginainicialIcon_Click(object sender, EventArgs e)
        {
            frmPaginaInicial paginaInicialForm = new frmPaginaInicial();
            paginaInicialForm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Omega
{
    public class FormManager
    {
        private Panel _painelPrincipal;

        public FormManager(Panel painelPrincipal)
        {
            _painelPrincipal = painelPrincipal;
        }

        public void AbrirFormNoPanel(Form formulario)
        {
            if (!_painelPrincipal.Controls.Contains(formulario))
            {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                _painelPrincipal.Controls.Add(formulario);
                _painelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            } else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }
    }
}

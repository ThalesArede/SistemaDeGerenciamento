using System;
using System.Windows.Forms;

namespace Omega
{
    public partial class frmTelaCarregamentoInicial : Form
    {
        private Timer timerCarregamento = new Timer();

        public frmTelaCarregamentoInicial()
        {
            InitializeComponent();

            timerCarregamento.Interval = 6000; // 6 segundos
            timerCarregamento.Tick += TimerCarregamento_Tick;
            timerCarregamento.Start();
        }

        private void TimerCarregamento_Tick(object sender, EventArgs e)
        {
            timerCarregamento.Stop();
            this.Hide();

            frmLoginPagina loginForm = new frmLoginPagina();
            loginForm.FormClosed += LoginForm_FormClosed;
            loginForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

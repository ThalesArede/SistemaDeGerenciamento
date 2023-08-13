using System;
using System.Text;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Omega
{
    public partial class frmLoginPagina : Form
    {
        public frmLoginPagina()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtSenha.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM tabela_usuarios WHERE nome_usuario = @username AND senha = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            frmPaginaInicial paginaInicialForm = new frmPaginaInicial();
                            paginaInicialForm.Show();
                            this.Hide();
                        } else
                        {
                            txtNaoCadastrado.ForeColor = Color.Red;
                            txtNaoCadastrado.Text = "Usuário ou senha incorretos.";
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro paginaInicialForm = new frmCadastro();
            paginaInicialForm.Show();
        }

        private void iX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SairIcone_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

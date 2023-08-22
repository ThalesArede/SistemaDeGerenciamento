using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Omega
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void SairIcone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoginPagina loginForm = new frmLoginPagina();
            loginForm.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txtNomeCompleto.Text;
            string email = txtEmail.Text;
            string nomeUsuario = txtNomeUsuario.Text;
            string senha = txtSenha.Text;

            // Verificar se algum campo está vazio
            if (string.IsNullOrWhiteSpace(nomeCompleto) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(nomeUsuario) ||
                string.IsNullOrWhiteSpace(senha))
            {
                txtMsgErro.ForeColor = Color.Red;
                txtMsgErro.Text = "Preencha todos os campos.";
                return; // Retorna sem prosseguir com o cadastro
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tabela_usuarios (nome_completo, nome_usuario, senha, email) VALUES (@nomeCompleto, @nomeUsuario, @senha, @email)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
                        command.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                        command.Parameters.AddWithValue("@senha", senha);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            txtMsgErro.Text = ""; // Limpa a mensagem de erro anterior
                            txtMsgErro.ForeColor = Color.Green;
                            txtMsgErro.Text = "Cadastro realizado com sucesso!";
                            // Limpar os campos do formulário após o cadastro
                            txtNomeCompleto.Text = "";
                            txtEmail.Text = "";
                            txtNomeUsuario.Text = "";
                            txtSenha.Text = "";
                        } else
                        {
                            txtMsgErro.ForeColor = Color.Red;
                            txtMsgErro.Text = "Erro ao cadastrar. Verifique os dados e tente novamente.";
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }


        private void iX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
